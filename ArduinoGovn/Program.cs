using System;
using System.Threading;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGovn
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void Izmenenie(object ip)
        {
            TIp sip = (TIp)ip;
            SerialPort port = new SerialPort("COM4", 19200);
            port.Open();
            while (true)
            {
                if ((char)port.ReadChar() == '1')
                {
                    while (true)
                    {
                        sip.form.BackColor = System.Drawing.Color.Red;
                        Thread.Sleep(1000);
                        sip.form.BackColor = System.Drawing.Color.Blue;
                        Thread.Sleep(1000);
                        if (sip.button.Checked== true)
                            goto NAX;
                    }
                }
            }
            NAX:;
        }
        
        
    }
    public class TIp
    {
        public Form form;
        public RadioButton button;
    }
}
