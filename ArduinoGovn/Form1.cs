using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGovn
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            SerialPort port = new SerialPort("COM4",9600);
            port.Open();
            char q = (char)port.ReadChar();
            //port.Read();
            port.Close();
        }
    }
}
