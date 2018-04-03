using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
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
            Thread myThread = new Thread(new ParameterizedThreadStart(Program.Izmenenie));
            TIp qq = new TIp();
            qq.button = this.radioButton1;
            qq.form = this;
            myThread.Start(qq);
        }
    }
}
