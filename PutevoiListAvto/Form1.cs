using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PutevoiListAvto
{
    public partial class Form1 : Form
    {
        SqlQueues queues = new SqlQueues();
        public Form1()
        {
            InitializeComponent();
        }
        List<string[]> companyNames = new List<string[]>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount += 1;
            dataGridView1[1, dataGridView1.Rows.Count - 1].Value = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            dataGridView1[0, dataGridView1.Rows.Count - 1].Value = dataGridView1.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckOnWhiteSpace() && CheckOnNumbers())
            {
                AddStroke();
                if (dataGridView1.Rows.Count > 0)
                {
                    DistanceEntity distanceEntity = new DistanceEntity
                                                        (dataGridView1[2, dataGridView1.Rows.Count - 2].Value.ToString(),
                                                        dataGridView1[3, dataGridView1.Rows.Count - 2].Value.ToString(),
                                                        dataGridView1[4, dataGridView1.Rows.Count - 2].Value.ToString(),
                                                        dataGridView1[5, dataGridView1.Rows.Count - 2].Value.ToString(),
                                                        dataGridView1[6,dataGridView1.Rows.Count - 2].Value.ToString());
                    dataGridView1[1, dataGridView1.Rows.Count - 1].Value = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                    dataGridView1[0, dataGridView1.Rows.Count - 1].Value = dataGridView1.Rows.Count;
                    SqlQueues sql = new SqlQueues();
                      sql.WriteCompany(distanceEntity.CompanyIn,distanceEntity.AddressIn,distanceEntity.CompanyOut,distanceEntity.AddressOut,
                                                                                                                        distanceEntity.Distance);
                }
            }
        }
        private void AddStroke()
        {
            dataGridView1.RowCount += 1;
        }
        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string TitleText = dataGridView1.Columns[2].HeaderText;
            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                textBox1 = e.Control as TextBox;
                if (textBox1 != null)
                {
                    textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
                    AddItems(dataCollection);
                    textBox1.AutoCompleteCustomSource = dataCollection;
                }
            }
            else
            {
                textBox1.AutoCompleteCustomSource = null;
            }
        }

        private void AddItems(AutoCompleteStringCollection col)
        {
            companyNames = queues.SuggestCompanyNames();
            for (int i = 0; i < companyNames.Count; i++)
            {
                col.Add(companyNames[i][0]);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((dataGridView1.CurrentCell.Value != null) && (companyNames != null) &&
                (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 4))
            {
                if (companyNames.Count > 0)
                {
                    for (int i = 0; i < companyNames.Count; i++)
                    {
                        if (companyNames[i][0] == dataGridView1.CurrentCell.Value.ToString())
                        {
                            dataGridView1[dataGridView1.CurrentCellAddress.X + 1, dataGridView1.CurrentCellAddress.Y].Value = companyNames[i][1];
                        }
                    }
                }

            }
            if (dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value != null && dataGridView1[4, dataGridView1.CurrentCellAddress.Y].Value != null)
            {
                string companyIn = dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value.ToString();
                string companyOut = dataGridView1[4, dataGridView1.CurrentCellAddress.Y].Value.ToString();
                double distance = queues.FindDistanceBetweenAddresses(companyIn, companyOut);
                if (distance != -1)
                {
                    dataGridView1[6, dataGridView1.CurrentCellAddress.Y].Value = distance;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1[1, dataGridView1.Rows.Count - 1].Value = dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }

        private bool CheckOnWhiteSpace()
        {
            foreach (DataGridViewRow rw in dataGridView1.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value)
                    {
                        label2.Text = "Присутствуют пустые ячейки";
                        return false;
                    }
                }
            }

            return true;
        }
        private bool CheckGasAndCost()
        {
            if (TB2.Text == null || TB2.Text.Length == 0)
            {
                label5.Text = "Введите неотрицательное число";
                return false;
            }
            else
            {
                if (!int.TryParse(TB2.Text, out int k))
                {
                    label5.Text = "Введите неотрицательное число";
                    return false;
                }
            }
            if (TB2.Text == null || TB2.Text.Length == 0)
            {
                label5.Text = "Введите неотрицательное число";
                return false;
            }
            else
            {
                if (!int.TryParse(TB3.Text, out int k))
                {
                    label5.Text = "Введите неотрицательное число";
                    return false;
                }
            }
            return true;
        }

        private bool CheckOnNumbers()
        {
            foreach (DataGridViewRow rw in dataGridView1.Rows)
            {
                if (!double.TryParse(rw.Cells[6].Value.ToString(), out double result))
                {
                    label2.Text = "Дистанция должна быть числом, дробь через точку";
                    return false;
                }
            }
            return true;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (CheckOnWhiteSpace() && CheckOnNumbers() && dataGridView1.CurrentCellAddress.Y > 0)
            {
                string buffer;
                int XCoord = dataGridView1.CurrentCellAddress.Y;
                for (int i = 1; i < 7; i++)
                {
                    buffer = dataGridView1[i, XCoord].Value.ToString();
                    dataGridView1[i, XCoord].Value = dataGridView1[i, XCoord - 1].Value;
                    dataGridView1[i, XCoord - 1].Value = buffer;
                }
                this.dataGridView1.CurrentCell = this.dataGridView1[dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y - 1];
            }
        }


        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (CheckOnWhiteSpace() && CheckOnNumbers() && dataGridView1.CurrentCellAddress.Y < dataGridView1.RowCount - 1)
            {
                string buffer;
                int XCoord = dataGridView1.CurrentCellAddress.Y;
                for (int i = 1; i < 7; i++)
                {
                    buffer = dataGridView1[i, XCoord].Value.ToString();
                    dataGridView1[i, XCoord].Value = dataGridView1[i, XCoord + 1].Value;
                    dataGridView1[i, XCoord + 1].Value = buffer;
                }
                this.dataGridView1.CurrentCell = this.dataGridView1[dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y + 1];
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1[0, i].Value = i + 1;
                    }

                }
            }
        }
        private void путевойЛистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k;
            if (CheckOnWhiteSpace() && CheckOnNumbers())
            {
                string[,] gridData = new string[dataGridView1.Rows.Count, 5];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    k = 0;
                    for (int j = 0; j < 7; j++)
                    {
                        if (j != 2 && j != 4)
                        {
                            gridData[i, k] = dataGridView1[j, i].Value.ToString();
                            k += 1;
                        }
                    }
                }
                ExportExcel ex = new ExportExcel();
                if (gridData != null)
                    ex.CreateExcelPutevoi(gridData);
            }
        }
        private void отчетНаБензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOnWhiteSpace() && CheckOnNumbers() && CheckGasAndCost())
            {
                string[] buffer = new string[4];
                List<string[]> bufferList = new List<string[]>();
                int k = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    k = 0;
                    buffer = new string[4];
                    for (int j = 0; j < 7; j++)
                    {
                        if (j != 3 && j != 5 && j != 4)
                        {
                            if (j == 2)
                            {
                                buffer[k] = dataGridView1[j, i].Value.ToString() + "-" + dataGridView1[4, i].Value.ToString();
                            }
                            else
                            {
                                buffer[k] = dataGridView1[j, i].Value.ToString();
                            }
                            k += 1;
                        }

                    }
                    if (bufferList.Count == 0)
                    {
                        bufferList.Add(buffer);
                    }
                    else
                    {
                        if (buffer[1] == bufferList[bufferList.Count - 1][1])
                        {
                            bufferList[bufferList.Count - 1][2] += ", " + buffer[2];
                            double summKM = double.Parse(bufferList[bufferList.Count - 1][3]) +
                                    double.Parse(buffer[3]);
                            bufferList[bufferList.Count - 1][3] = summKM.ToString();
                        }
                        else
                        {
                            bufferList.Add(buffer);
                        }
                    }
                }
                ExportExcel ex = new ExportExcel();
                if (bufferList != null)
                    ex.CreateExcelOtchet(bufferList, TB2.Text, TB3.Text);
            }
        }

        private void SqliteEditButton_Click(object sender, EventArgs e)
        {
            SqliteForm sqliteForm = new SqliteForm();
            sqliteForm.ShowDialog();
           
        }
    }
}
