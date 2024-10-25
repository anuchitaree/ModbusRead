using EasyModbus;
using ModbusRead.Models;
using ModbusRead.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ModbusRead
{
    public partial class MainForm : Form
    {
        ModbusClient modbusClient = new ModbusClient();
        DispatcherTimer timerPoll = new DispatcherTimer();
        byte unitIdentify = 1;
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
                    btnConnect.BackColor = Color.GreenYellow;
                    cmbRegType.Enabled = true;
                    lbStatus.Text = "";
                    
                }
                else
                {
                    modbusClient.Disconnect();
                    btnConnect.Text = "CONNECT";
                    btnConnect.BackColor = SystemColors.Control;
                    timerPoll.Tick -= timerPoll_Tick;
                    cmbRegType.Enabled = false;

                }
                dgv.Rows.Clear();
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
            try
            {
                if (modbusClient.Connected == true)
                {
                    modbusClient.UnitIdentifier = byte.Parse(cmbIdentify.Text);

                    int startaddr = int.Parse(txtStartAddr.Text);
                    int qty = int.Parse(txtQty.Text);

                    List<Readmodel> readmodelList = new List<Readmodel>();

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
                                        Reg = cmbRegType.SelectedIndex,
                                        Address = (0 + i + startaddr).ToString().PadLeft(6, '0').Insert(3, " "),
                                        DecString = vals[i] == true ? "True" : "False",
                                        DecValue = 0,
                                        HexString = vals[i] == true ? "1" : "0",
                                    };
                                    readmodelList.Add(model);

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
                                        Reg = cmbRegType.SelectedIndex,
                                        Address = (100000 + i + startaddr).ToString().PadLeft(6, '0').Insert(3, " "),
                                        DecString = vals[i] == true ? "True" : "False",
                                        DecValue = 0,
                                        HexString = vals[i] == true ? "1" : "0",
                                    };
                                    readmodelList.Add(model);

                                }

                            }
                            break;
                        case 2:
                            if (true)
                            {
                                var c = 0;
                                int[] vals = modbusClient.ReadInputRegisters(startaddr, qty);
                                for (int i = 0; i < qty; i++)
                                {
                                    int int32 = 0;
                                    if (c == 1)
                                    {
                                        int32 = Convertion.Short2Int(vals[i - 1], vals[i]);
                                        c = 0;
                                    }
                                    else
                                    {
                                        int32 = 0;
                                        c++;
                                    }
                                    var model = new Readmodel()
                                    {
                                        Id = i + 1,
                                        Reg = cmbRegType.SelectedIndex,
                                        Address = (300000 + i + startaddr).ToString().PadLeft(6, '0').Insert(3, " "),
                                        DecString = vals[i].ToString(),
                                        DecValue = vals[i],
                                        HexString = Convertion.Dec2Hex(vals[i]),
                                        Int32Value = int32,
                                    };
                                    readmodelList.Add(model);

                                }

                            }

                            break;
                        case 3:
                            if (true)
                            {
                                var c = 0;
                                int[] vals = modbusClient.ReadHoldingRegisters(startaddr, qty);
                                for (int i = 0; i < qty; i++)
                                {
                                    int int32 = 0;
                                    if (c == 1)
                                    {
                                        int32 = Convertion.Short2Int(vals[i - 1], vals[i]);
                                        c = 0;
                                    }
                                    else
                                    {
                                        int32 = 0;
                                        c++;
                                    }
                                    var model = new Readmodel()
                                    {
                                        Id = i + 1,
                                        Reg = cmbRegType.SelectedIndex,
                                        Address = (400000 + i + startaddr).ToString().PadLeft(6, '0').Insert(3, " "),
                                        DecString = vals[i].ToString(),
                                        DecValue = vals[i],
                                        HexString = Convertion.Dec2Hex(vals[i]),
                                        Int32Value = int32,
                                    };
                                    readmodelList.Add(model);
                                }


                            }
                            break;
                    }

                    dgv.Rows.Clear();
                    var r = 0;

                    foreach (var item in readmodelList.OrderBy(x => x.Id).ToList())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgv);
                        row.Cells[0].Value = item.Address;
                        if (item.Reg == 2 || item.Reg == 3)
                        {
                            row.Cells[2].Value = item.HexString;
                            row.Cells[1].Value = item.DecValue;
                            row.Cells[3].Value = item.Int32Value;
                        }
                        else
                        {
                            row.Cells[2].Value = item.HexString.PadLeft(4, '0');
                            row.Cells[1].Value = item.DecString;
                        }
                        dgv.Rows.Add(row);

                        r++;
                    }



                }
                else
                {
                    modbusClient.Disconnect();
                    btnConnect.Text = "CONNECT";
                    btnConnect.BackColor = SystemColors.Control;
                    timerPoll.Tick -= timerPoll_Tick;
                }

            }
            catch (Exception ex)
            {
                ex.ToString();

                modbusClient.Disconnect();
                btnConnect.Text = "CONNECT";
                btnConnect.BackColor = SystemColors.Control;
                timerPoll.Tick -= timerPoll_Tick;
                cmbRegType.Enabled = false;

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbRegType.SelectedIndex = 0;
            cmbRegType.Enabled = false;

            InitDvg();
            for (int i = 0; i < 31; i++)
            {
                cmbIdentify.Items.Add(i + 1);
            }
            cmbIdentify.SelectedIndex = 0;
        }

        private void InitDvg()
        {
            this.dgv.ColumnCount = 4;

            this.dgv.Columns[0].Name = "Address";
            this.dgv.Columns[0].Width = 80;
            this.dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgv.Columns[1].Name = "DEC/BOOL";
            this.dgv.Columns[1].Width = 100;
            this.dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns[2].Name = "HEX";
            this.dgv.Columns[2].Width = 80;
            this.dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns[3].Name = "Int32";
            this.dgv.Columns[3].Width = 100;
            this.dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void cmbIdentify_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitIdentify = byte.Parse(cmbIdentify.Text);
        }
    }
}
