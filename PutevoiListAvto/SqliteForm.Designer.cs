
namespace PutevoiListAvto
{
    partial class SqliteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqliteForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.CompanyIn,
            this.AddressIn,
            this.CompanyOut,
            this.AddressOut,
            this.distance});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(919, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Number
            // 
            this.Number.FillWeight = 40F;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // CompanyIn
            // 
            this.CompanyIn.FillWeight = 80F;
            this.CompanyIn.HeaderText = "Место отправления (компания)";
            this.CompanyIn.Name = "CompanyIn";
            this.CompanyIn.ReadOnly = true;
            // 
            // AddressIn
            // 
            this.AddressIn.FillWeight = 120F;
            this.AddressIn.HeaderText = "Адрес отправления";
            this.AddressIn.Name = "AddressIn";
            this.AddressIn.ReadOnly = true;
            // 
            // CompanyOut
            // 
            this.CompanyOut.FillWeight = 80F;
            this.CompanyOut.HeaderText = "Место назначения (компания)";
            this.CompanyOut.Name = "CompanyOut";
            this.CompanyOut.ReadOnly = true;
            // 
            // AddressOut
            // 
            this.AddressOut.FillWeight = 120F;
            this.AddressOut.HeaderText = "Адрес назначения";
            this.AddressOut.Name = "AddressOut";
            this.AddressOut.ReadOnly = true;
            // 
            // distance
            // 
            this.distance.FillWeight = 50F;
            this.distance.HeaderText = "Дистанция";
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(38, 359);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(92, 35);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить строку";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(153, 359);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 35);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить строку";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SqliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 465);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SqliteForm";
            this.Text = "SqliteForm";
            this.Load += new System.EventHandler(this.SqliteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
    }
}