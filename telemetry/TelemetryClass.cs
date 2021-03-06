﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NEW
using OpenHardwareMonitor;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;
using System.Speech.Synthesis;
using System.Threading;
using System.Management;
using System.Management.Instrumentation;
using System.Collections.Specialized;


namespace telemetry
{
    public class Telemetry
    {
        public static PerformanceCounter PC_uptime = new PerformanceCounter("System", "System Up Time"); //uptime from the Performance Counter of windows
        public static Computer pc;

        public Telemetry()
        {
            pc = new Computer() //Creating the computer object for readings
             {
                 CPUEnabled = true, //initialize the CPU
                 GPUEnabled = true //initialize the GPU
             };
            PC_uptime.NextValue(); //the method will activate all this things and then start the thread that actually prints the info
            pc.Open();
        }
        public string UpTime() //Returns a string with the uptime
        {
            TimeSpan uptimeSpan = TimeSpan.FromSeconds(PC_uptime.NextValue()); // convert uptime to seconds
            string timeawake = string.Format("{0}:{1}:{2}:{3}", //store uptime formated into a string
                (int)uptimeSpan.TotalDays, //this stores the total of days
                (int)uptimeSpan.Hours,      //this stores the hours since last day
                (int)uptimeSpan.Minutes,    //this stores the minutes passed since last hour
                (int)uptimeSpan.Seconds        // this stores the seconds since last minute
                );

            return timeawake;
        }

        public float CPU_load() //float with the load of the CPU
        {
            float load = 0;
            try
            {
                #region //foreach thingy things
                foreach (var hardwareItem in pc.Hardware)  //store the hardware in hardwareItem
                {

                    if (hardwareItem.HardwareType == HardwareType.CPU) //Select the CPU of the hardware list
                    {
                        hardwareItem.Update(); //call the update (i don't know what this is actually
                        foreach (var sensorItem in hardwareItem.Sensors) //store every sensor of the CPU on sensorItem
                        {
                            if (sensorItem.SensorType == SensorType.Load) //If the sensorItem is a temperature sensor , prints the value OR the default
                            {
                                load = sensorItem.Value.GetValueOrDefault();
                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                load = 0;
               /* Console.WriteLine("ERROR READING CPU LOAD");
                Console.WriteLine("SOMETHING WENT AWFULLY WRONG");
                Console.WriteLine(ex.Message);*/
            }

            return load;

        }


        public float CPU_temp() //float with the temperature of the CPU
        {
            float temp = 0;
            try
            {
                #region //foreach thingy things
                foreach (var hardwareItem in pc.Hardware)  //store the hardware in hardwareItem
                {

                    if (hardwareItem.HardwareType == HardwareType.CPU) //Select the CPU of the hardware list
                    {
                        hardwareItem.Update(); //call the update (i don't know what this is actually
                        foreach (var sensorItem in hardwareItem.Sensors) //store every sensor of the CPU on sensorItem
                        {
                            if (sensorItem.SensorType == SensorType.Temperature) //If the sensorItem is a temperature sensor , prints the value OR the default
                            {
                                temp = sensorItem.Value.GetValueOrDefault();
                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                temp = 69;
                /*
                Console.WriteLine("ERROR READING CPU TEMPERATURE");
                Console.WriteLine("MAKE SURE THE APP HAS ADMIN RIGHTS");
                Console.WriteLine(ex.Message);*/
            }

            return temp;
        }


        public bool hddActivity()
        {
            bool isActive = false;
            // esta cosa pide datos del WMI
            ManagementClass hddDataClass = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk");

            ManagementObjectCollection hddDataCollection = hddDataClass.GetInstances();


            foreach (ManagementObject instance in hddDataCollection)
            {
                //Onlye process the total 
                if (instance["Name"].ToString() == "_Total")
                {
                    //
                    if (Convert.ToUInt64(instance["DiskBytesPersec"]) > 0)// se explca solo
                    {
                        isActive = true;//is active
                    }

                    else
                    {
                        isActive = false;//is idle
                    }
                }
            }

            return isActive;
        }


        public class voice
        {
            public static Thread speaky;

            public static SpeechSynthesizer synth = new SpeechSynthesizer();
            public static string message;
            public static int rate;


            public static void Speak(string m, int r) //speak the message at the desired speed (rate)
            {
                message = m;
                rate = r;
                speaky = new Thread(spThread); //WIP
                speaky.Start();
               
            }

           /* public static void Speak(string m, int r) //speak the message at the desired speed (rate)
            {
                synth.Volume = 100;
                synth.Rate = rate;
                synth.Speak(message);

            }*/

            static void spThread() //fix this, it's not working
            {
                synth.Volume = 100;
                synth.Rate = rate;
                synth.Speak(message);
                speaky.Abort();
            }

        }
    }
}
