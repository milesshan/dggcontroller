using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace DGG_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayAvailablePorts();
        }

        void displayAvailablePorts()
        {
            comboboxAvailablePorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(comboboxAvailablePorts.Text == "")
            {
                textboxReceived.Text = "Please select a COM port";
            }
            else
            {  
                if((port != null) && port.IsOpen)
                {
                    port.Close();
                }

                port = new SerialPort(comboboxAvailablePorts.Text);

                if (!port.isInit)
                {
                    textboxReceived.Text = "COM port did not initialize.";
                }
                else
                {
                    textboxReceived.Text = "COM successfully initialized.";
                }
            }
        }
        
        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if ((port != null) && port.IsOpen)
            {
                double delay = 0;
                if (double.TryParse(textboxDelay.Text, out delay) && delay >= 0)
                {
                    port.boardSetDelay(Convert.ToDouble(textboxDelay.Text));
                    textboxSent.Text = "Delay: " + textboxDelay.Text + "ns";
                }
                else
                {
                    textboxReceived.Text = "Please input a valid positive delay in nanoseconds.";
                }
            }
        }
        private void textboxDelay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((port != null) && port.IsOpen)
            {
                port.boardSetDelay(0);
                port.boardReset();
                port.Close();
            }
        }

        private SerialPort port;
    }
}
