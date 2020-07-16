using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Class
{
    class ClsSms
    {
        public string[] strarray = new string[10];
        SerialPort serialport1 = new SerialPort();
        public string com = "";
        int mybaudrate = 9600;


        //this.strarray =System.IO.Ports.SerialPort.GetPortNames();


        public void getports()
        {
            this.strarray = System.IO.Ports.SerialPort.GetPortNames();

        }

        public bool connetport()
        {
            bool Isopen;
            serialport1.Close();
            try
            {
                if (!this.serialport1.IsOpen)
                {
                    this.serialport1.PortName = com;

                    this.serialport1.Open();
                    this.serialport1.BaudRate = mybaudrate;
                    this.serialport1.StopBits = System.IO.Ports.StopBits.One;
                    this.serialport1.Parity = System.IO.Ports.Parity.None;
                    this.serialport1.Handshake = System.IO.Ports.Handshake.None;

                    Isopen = serialport1.IsOpen;




                }

                Isopen = true;


            }

            catch (Exception ex)
            {
                Isopen = false;
                throw ex;
            }
            return Isopen;
        }

        public void sendsms(string message, string phone)
        {
            try
            {

                if (this.serialport1.IsOpen)
                {

                    // Pour envoyer un gros sms
                    serialport1.BaseStream.Flush();

                    string cb = char.ConvertFromUtf32(26);
                    this.serialport1.Write("AT+CMGF=1\r");
                    Thread.Sleep(1000);
                    //this.serialport1.Write("AT+CSCA=servicecenter\r   \n");//Ufone Service Center 
                    //Thread.Sleep(1000);
                    this.serialport1.Write("AT+CMGS=\"" + phone + "\"\r\n");// 
                    Thread.Sleep(1000);
                    this.serialport1.Write(message+" "+ cb);//message text message sending
                    Thread.Sleep(1000);
                    var response = serialport1.ReadExisting();
                    if (response.Contains("ERROR"))
                    {
                        MessageBox.Show("Send failed !"+ response, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    serialport1.Close();

                }
            }
            catch (Exception ex)
            {
                serialport1.Close();
                MessageBox.Show("Send failed !\n" + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
