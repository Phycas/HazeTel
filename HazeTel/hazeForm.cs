using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using telemetry;

namespace HazeTel
{
    public partial class hazeForm : Form
    {
        private double release = 1.2;
        private bool voiceActive = true;

        Telemetry teletest = new Telemetry();
        public bool runTele = true;
        public hazeForm()
        {
            InitializeComponent();
            
            string v = String.Format(" v{0}", release.ToString());
            this.Text = this.Text + v ;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            
            Thread tely = new Thread(printThread); // starts the telemetry thread
            loadLabel.BackColor = Color.Transparent;
            tely.Start();
        }

     

        private void exitButton_Click(object sender, EventArgs e) //a better way to exit the program
        {
            runTele = false; //stops the while loop on the printThread

            Application.Exit();

        }

        private void  updateLabels(string[] weas) // This updates the telemetry labels
        {
            
            tempLabel.Text = weas[0];
            loadLabel.Text = weas[1];
            upTimeLabel.Text = weas[2];

        }

        private void printThread()
        {
            //while (true)
            while (runTele)
            {

                int temp = (int)teletest.CPU_temp();
                

                int load = (int)teletest.CPU_load();
                

                string uptime = teletest.UpTime();

                string[] reporte = new string[3];
                if (temp < 10)
                {
                    reporte[0] = String.Format("0" + temp.ToString());
                }
                else
                    reporte[0] = temp.ToString();

                if (load < 10)
                {
                    reporte[1] = String.Format("0" + load.ToString());
                }
                else if (load > 99)
                {
                    reporte[1] = "99";
                }
                else
                    reporte[1] = load.ToString();

                reporte[2] = uptime;
                 // running on worker thread
                this.Invoke((MethodInvoker)delegate {
                    updateLabels(reporte); // runs on UI thread
                });

                //voice
                if (voiceActive)
                {
                    if (temp >= 60)
                        Telemetry.voice.Speak("Core Temperature over sixty degrees", 2);
                }

                Thread.Sleep(400);
                 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (voiceActive)
            {
                voiceActive = false;

                label1.Text = "voice off";
            }

            else if (voiceActive == false)
            {
                voiceActive = true;
                Telemetry.voice.Speak("voice activated", 2);
                label1.Text = "voice on";
            }
        }
    }
}
