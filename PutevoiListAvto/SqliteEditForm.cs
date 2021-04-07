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
    public partial class SqliteEditForm : Form
    {
        DistanceEntity distanceEntity;
        public string NewCompanyIn{ get; set; }
        public string NewAddressIn{ get; set; }
        public string NewCompanyOut{ get; set; }
        public string NewAddressOut{ get; set; }
        public double NewDistance{ get; set; }
        public SqliteEditForm(string companyIn, string addressIn, string companyOut, string addressOut, string distance)
        {
            InitializeComponent();
            distanceEntity = new DistanceEntity(companyIn, addressIn, companyOut, addressOut, distance);
            CompanyInTextBox.Text = distanceEntity.CompanyIn;
            AddressInTextBox.Text = distanceEntity.AddressIn;
            CompanyOutTextBox.Text = distanceEntity.CompanyOut;
            AddressOutTextBox.Text = distanceEntity.AddressOut;
            DistanceTextBox.Text = distanceEntity.Distance;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }
        private void declineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyInTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = CompanyInTextBox.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(CompanyInTextBox, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(CompanyInTextBox, String.Empty);
                e.Cancel = false;
            }
        }
        private void CompanyInTextBox_Validated(object sender, EventArgs e)
        {
            NewCompanyIn = CompanyInTextBox.Text;
        }


        private void AddressInTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = AddressInTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(AddressInTextBox, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(AddressInTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void AddressInTextBox_Validated(object sender, EventArgs e)
        {
            NewAddressIn = AddressInTextBox.Text;
        }

        private void CompanyOutTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = CompanyOutTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(CompanyOutTextBox, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(CompanyOutTextBox, String.Empty);
                e.Cancel = false;
            }
        }
        private void CompanyOutTextBox_Validated(object sender, EventArgs e)
        {
            NewCompanyOut = CompanyOutTextBox.Text;
        }

        private void AddressOutTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = AddressOutTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(AddressOutTextBox, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(AddressOutTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void AddressOutTextBox_Validated(object sender, EventArgs e)
        {
            NewAddressOut = AddressOutTextBox.Text;
        }

        private void DistanceTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = DistanceTextBox.Text;
            double doubleInput;
            if(!double.TryParse(DistanceTextBox.Text, out doubleInput))
            {
                errorProvider1.SetError(DistanceTextBox, "Некорректное значение!");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(CompanyInTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void DistanceTextBox_Validated(object sender, EventArgs e)
        {
            NewDistance = double.Parse(DistanceTextBox.Text);
        }

       
    }
}
