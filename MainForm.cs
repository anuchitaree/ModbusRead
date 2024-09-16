using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using EasyModbus;

namespace ModbusRead
{
    public partial class MainForm : Form
    {
        ModbusClient modbusClient = new ModbusClient();
        DispatcherTimer timerPoll = new DispatcherTimer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "CONNECT")
                {
                    modbusClient.IPAddress = "192.168.100.127";
                    modbusClient.Port = 502;
                    modbusClient.ConnectionTimeout = 5000;
                    modbusClient.Connect();
                    timerPoll.Interval = TimeSpan.FromSeconds(1);
                    timerPoll.Tick += timerPoll_Tick;
                    timerPoll.Start();
                    btnConnect.Text = "CONNECTED";
                    lbStatus.Text = "";
                }
                else
                {
                    modbusClient.Disconnect();
                    btnConnect.Text = "CONNECT";
                    timerPoll.Tick -= timerPoll_Tick;
                }
            }
            catch (EasyModbus.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine(ex.Message);
                lbStatus.Text = "Status : Connection timed out";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void timerPoll_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {
                int[] vals = modbusClient.ReadHoldingRegisters(0, 10);
                label1.Text = vals[0].ToString();
                label2.Text = vals[1].ToString();
                label3.Text = vals[2].ToString();
                label4.Text = vals[3].ToString();
                label5.Text = vals[4].ToString();
                label6.Text = vals[5].ToString();
                label7.Text = vals[6].ToString();
                label8.Text = vals[7].ToString();
                label9.Text = vals[8].ToString();

                textBox1.Text = null;

                int[] hols = modbusClient.ReadInputRegisters(0, 10);
                foreach (int i in hols) {
                    textBox1.Text += i.ToString() + ",";
                }
                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbRegType.SelectedIndex = 0;
        }
    }
}
