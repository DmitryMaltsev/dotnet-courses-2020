
namespace PutevoiListAvto
{
    partial class SqliteEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqliteEditForm));
            this.CompanyInTextBox = new System.Windows.Forms.TextBox();
            this.CompanyOutTextBox = new System.Windows.Forms.TextBox();
            this.AddressInTextBox = new System.Windows.Forms.TextBox();
            this.AddressOutTextBox = new System.Windows.Forms.TextBox();
            this.CompanyInLabel = new System.Windows.Forms.Label();
            this.AddressInLabel = new System.Windows.Forms.Label();
            this.CompanyOutLabel = new System.Windows.Forms.Label();
            this.AddressOutLabel = new System.Windows.Forms.Label();
            this.DisatanceLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyInTextBox
            // 
            this.CompanyInTextBox.Location = new System.Drawing.Point(130, 13);
            this.CompanyInTextBox.Name = "CompanyInTextBox";
            this.CompanyInTextBox.Size = new System.Drawing.Size(180, 20);
            this.CompanyInTextBox.TabIndex = 0;
            this.CompanyInTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyInTextBox_Validating);
            this.CompanyInTextBox.Validated += new System.EventHandler(this.CompanyInTextBox_Validated);
            // 
            // CompanyOutTextBox
            // 
            this.CompanyOutTextBox.Location = new System.Drawing.Point(130, 94);
            this.CompanyOutTextBox.Name = "CompanyOutTextBox";
            this.CompanyOutTextBox.Size = new System.Drawing.Size(180, 20);
            this.CompanyOutTextBox.TabIndex = 1;
            this.CompanyOutTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyOutTextBox_Validating);
            this.CompanyOutTextBox.Validated += new System.EventHandler(this.CompanyOutTextBox_Validated);
            // 
            // AddressInTextBox
            // 
            this.AddressInTextBox.Location = new System.Drawing.Point(130, 50);
            this.AddressInTextBox.Name = "AddressInTextBox";
            this.AddressInTextBox.Size = new System.Drawing.Size(180, 20);
            this.AddressInTextBox.TabIndex = 2;
            this.AddressInTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressInTextBox_Validating);
            this.AddressInTextBox.Validated += new System.EventHandler(this.AddressInTextBox_Validated);
            // 
            // AddressOutTextBox
            // 
            this.AddressOutTextBox.Location = new System.Drawing.Point(130, 140);
            this.AddressOutTextBox.Name = "AddressOutTextBox";
            this.AddressOutTextBox.Size = new System.Drawing.Size(180, 20);
            this.AddressOutTextBox.TabIndex = 3;
            this.AddressOutTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressOutTextBox_Validating);
            this.AddressOutTextBox.Validated += new System.EventHandler(this.AddressOutTextBox_Validated);
            // 
            // CompanyInLabel
            // 
            this.CompanyInLabel.AutoSize = true;
            this.CompanyInLabel.Location = new System.Drawing.Point(16, 16);
            this.CompanyInLabel.Name = "CompanyInLabel";
            this.CompanyInLabel.Size = new System.Drawing.Size(108, 13);
            this.CompanyInLabel.TabIndex = 4;
            this.CompanyInLabel.Text = "Компания отправки";
            // 
            // AddressInLabel
            // 
            this.AddressInLabel.AutoSize = true;
            this.AddressInLabel.Location = new System.Drawing.Point(16, 53);
            this.AddressInLabel.Name = "AddressInLabel";
            this.AddressInLabel.Size = new System.Drawing.Size(88, 13);
            this.AddressInLabel.TabIndex = 5;
            this.AddressInLabel.Text = "Адрес отправки";
            // 
            // CompanyOutLabel
            // 
            this.CompanyOutLabel.AutoSize = true;
            this.CompanyOutLabel.Location = new System.Drawing.Point(16, 101);
            this.CompanyOutLabel.Name = "CompanyOutLabel";
            this.CompanyOutLabel.Size = new System.Drawing.Size(110, 13);
            this.CompanyOutLabel.TabIndex = 6;
            this.CompanyOutLabel.Text = "Компания прибытия";
            // 
            // AddressOutLabel
            // 
            this.AddressOutLabel.AutoSize = true;
            this.AddressOutLabel.Location = new System.Drawing.Point(16, 143);
            this.AddressOutLabel.Name = "AddressOutLabel";
            this.AddressOutLabel.Size = new System.Drawing.Size(90, 13);
            this.AddressOutLabel.TabIndex = 7;
            this.AddressOutLabel.Text = "Адрес прибытия";
            // 
            // DisatanceLabel
            // 
            this.DisatanceLabel.AutoSize = true;
            this.DisatanceLabel.Location = new System.Drawing.Point(16, 183);
            this.DisatanceLabel.Name = "DisatanceLabel";
            this.DisatanceLabel.Size = new System.Drawing.Size(63, 13);
            this.DisatanceLabel.TabIndex = 9;
            this.DisatanceLabel.Text = "Дистанция";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(130, 180);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(180, 20);
            this.DistanceTextBox.TabIndex = 8;
            this.DistanceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DistanceTextBox_Validating);
            this.DistanceTextBox.Validated += new System.EventHandler(this.DistanceTextBox_Validated);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(62, 215);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(186, 215);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(75, 23);
            this.declineButton.TabIndex = 11;
            this.declineButton.Text = "Отмена";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SqliteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.DisatanceLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.AddressOutLabel);
            this.Controls.Add(this.CompanyOutLabel);
            this.Controls.Add(this.AddressInLabel);
            this.Controls.Add(this.CompanyInLabel);
            this.Controls.Add(this.AddressOutTextBox);
            this.Controls.Add(this.AddressInTextBox);
            this.Controls.Add(this.CompanyOutTextBox);
            this.Controls.Add(this.CompanyInTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SqliteEditForm";
            this.Text = "Редактировать маршрут";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyInTextBox;
        private System.Windows.Forms.TextBox CompanyOutTextBox;
        private System.Windows.Forms.TextBox AddressInTextBox;
        private System.Windows.Forms.TextBox AddressOutTextBox;
        private System.Windows.Forms.Label CompanyInLabel;
        private System.Windows.Forms.Label AddressInLabel;
        private System.Windows.Forms.Label CompanyOutLabel;
        private System.Windows.Forms.Label AddressOutLabel;
        private System.Windows.Forms.Label DisatanceLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}