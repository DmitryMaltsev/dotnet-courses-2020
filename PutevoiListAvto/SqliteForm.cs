using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutevoiListAvto
{
    public partial class SqliteForm : Form
    {
        public SqliteForm()
        {
            InitializeComponent();
        }

        private void SqliteForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 0;
            SqlQueues sqlQueues = new SqlQueues();
            List<string[]> distanceList = sqlQueues.SelectBDTable();
            int k = 1;
            foreach (string[] distance in distanceList)
            {
                dataGridView1.RowCount += 1;
                dataGridView1[0, k - 1].Value = k;
                dataGridView1[1, k - 1].Value = distance[0];
                dataGridView1[2, k - 1].Value = distance[1];
                dataGridView1[3, k - 1].Value = distance[2];
                dataGridView1[4, k - 1].Value = distance[3];
                dataGridView1[5, k - 1].Value = distance[4];

                k += 1;
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {              
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBD();
        }
        private void EditBD()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DistanceEntity entity = new DistanceEntity(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                                                           dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                                                           dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                                                           dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                                                           dataGridView1.CurrentRow.Cells[5].Value.ToString());
                SqliteEditForm sqliteEditForm = new SqliteEditForm(entity.CompanyIn, entity.AddressIn,
                                                                    entity.CompanyOut, entity.AddressOut, entity.Distance);
                if (sqliteEditForm.ShowDialog() == DialogResult.OK)
                {
                    DistanceEntity newEntity = new DistanceEntity(sqliteEditForm.NewCompanyIn, sqliteEditForm.NewAddressIn,
                                                              sqliteEditForm.NewCompanyOut, sqliteEditForm.NewAddressOut, sqliteEditForm.NewDistance.ToString());
                    SqlQueues sqlQueues = new SqlQueues();
                    sqlQueues.UpdateCompany(entity.CompanyIn, entity.CompanyOut, newEntity);
                    UpdateTable();
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBD();
        }
        
        private void DeleteBD()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DistanceEntity entity = new DistanceEntity(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                                                               dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                                                               dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                                                               dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                                                               dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    SqlQueues sqlQueues = new SqlQueues();
                    sqlQueues.DeleteDistance(entity);
                    UpdateTable();

                }

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                dataGridView1[0,0].Selected = true;
                dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;
             
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditBD();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteBD();
        }
    }
}
