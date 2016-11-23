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
    public partial class Form1 : Form
    {

        Telemetry teletest = new Telemetry();
        public bool runTele = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread tely = new Thread(printThread);

            tely.Start();
        }

     

        private void exitButton_Click(object sender, EventArgs e)
        {
            runTele = false;

            Application.Exit();

        }

        private void  updateLabels(string[] weas)
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
                string grados = "Temperature: " + temp + " c°";

                int load = (int)teletest.CPU_load();
                string porcentaje = "CPU usage:" + load + "%";

                string uptime = teletest.UpTime();

                string[] reporte = new string[3];
                reporte[0] = grados;
                reporte[1] = porcentaje;
                reporte[2] = uptime;
                 // running on worker thread
                this.Invoke((MethodInvoker)delegate {
                    updateLabels(reporte); // runs on UI thread
                });

                Thread.Sleep(1000);
                 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
