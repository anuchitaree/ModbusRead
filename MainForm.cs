using EasyModbus;
using ModbusRead.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;

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
                    string ip = txtAddrIp.Text.Trim();
                    int port = int.Parse(txtPort.Text.Trim());
                    double autoupdate = double.Parse(txtUpdate.Text);
                    int timeout = int.Parse(txtTimeOut.Text);

                    modbusClient.IPAddress = ip;
                    modbusClient.Port = port;
                    modbusClient.ConnectionTimeout = timeout;
                    modbusClient.Connect();
                    timerPoll.Interval = TimeSpan.FromSeconds(autoupdate);
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
                int startaddr = int.Parse(txtStartAddr.Text);
                int qty = int.Parse(txtQty.Text);

                List<Readmodel> readmodel = new List<Readmodel>();

                switch (cmbRegType.SelectedIndex)
                {
                    case 0:
                        if (true)
                        {
                            bool[] vals = modbusClient.ReadCoils(startaddr, qty);

                            for (int i = 0; i < qty; i++)
                            {
                                var model = new Readmodel()
                                {
                                    Id = i + 1,
                                    Address = (0 + i).ToString().PadLeft(6, '0').Insert(3, " "),
                                    HexValue = null,
                                    DecValue = vals[i].ToString(),
                                };
                                readmodel.Add(model);

                            }


                        }

                        break;
                    case 1:
                        if (true)
                        {
                            bool[] vals = modbusClient.ReadDiscreteInputs(startaddr, qty);
                            for (int i = 0; i < qty; i++)
                            {
                                var model = new Readmodel()
                                {
                                    Id = i + 1,
                                    Address = (200000 + i).ToString().PadLeft(6, '0').Insert(3, " "),
                                    HexValue = null,
                                    DecValue = vals[i].ToString(),
                                };
                                readmodel.Add(model);

                            }

                        }
                        break;
                    case 2:
                        if (true)
                        {
                            int[] vals = modbusClient.ReadHoldingRegisters(startaddr, qty);
                            for (int i = 0; i < qty; i++)
                            {
                                var model = new Readmodel()
                                {
                                    Id = i + 1,
                                    Address = (300000 + i).ToString().PadLeft(6, '0').Insert(3, " "),
                                    HexValue = null,
                                    DecValue = vals[i].ToString(),
                                };
                                readmodel.Add(model);

                            }

                        }

                        break;
                    case 3:
                        if (true)
                        {
                            int[] vals = modbusClient.ReadInputRegisters(startaddr, qty);
                            for (int i = 0; i < qty; i++)
                            {
                                var model = new Readmodel()
                                {
                                    Id = i + 1,
                                    Address = (400000 + i).ToString().PadLeft(6, '0').Insert(3, " "),
                                    DecValue = vals[i].ToString(),
                                };
                                readmodel.Add(model);

                            }


                        }
                        break;
                }

                dgv.Rows.Clear();
                var r = 0;
                foreach (var item in readmodel)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgv);
                    row.Cells[0].Value = item.Id;
                    row.Cells[1].Value = item.Address;
                    row.Cells[2].Value = item.DecValue;
                    if (item.DecValue == "True" || item.DecValue == "False")
                    { 
                    
                    }
                    else
                    {


                     var hexStr    = int.Parse(item.DecValue, System.Globalization.NumberStyles.HexNumber).ToString();
                        row.Cells[3].Value = hexStr.PadLeft(4,'0');

                    }
                    //string.Format("{0:x}", item.DecValue);
                    dgv.Rows.Add(row);

                    r++;
                }



            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbRegType.SelectedIndex = 0;
            InitDvg();
        }

        private void InitDvg()
        {
            this.dgv.ColumnCount = 4;
            this.dgv.Columns[0].Name = "No";
            this.dgv.Columns[0].Width = 30;
            this.dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[1].Name = "Address";
            this.dgv.Columns[1].Width = 200;
            this.dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[2].Name = "DEC";
            this.dgv.Columns[2].Width = 200;
            this.dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[3].Name = "HEX";
            this.dgv.Columns[3].Width = 200;
            this.dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgv.RowHeadersWidth = 4;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
        }
    }
}
