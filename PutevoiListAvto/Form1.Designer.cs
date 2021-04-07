
namespace PutevoiListAvto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.путевойЛистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетНаБензинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SqliteEditButton = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Data,
            this.AdressFrom,
            this.CompanyNameFrom,
            this.CompanyNameIn,
            this.PlaceIn,
            this.DistanceKm});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(924, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(128, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата поездки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.путевойЛистToolStripMenuItem,
            this.отчетНаБензинToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripDropDownButton1.Text = "Печать Excel";
            // 
            // путевойЛистToolStripMenuItem
            // 
            this.путевойЛистToolStripMenuItem.Name = "путевойЛистToolStripMenuItem";
            this.путевойЛистToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.путевойЛистToolStripMenuItem.Text = "Путевой лист";
            this.путевойЛистToolStripMenuItem.Click += new System.EventHandler(this.путевойЛистToolStripMenuItem_Click);
            // 
            // отчетНаБензинToolStripMenuItem
            // 
            this.отчетНаБензинToolStripMenuItem.Name = "отчетНаБензинToolStripMenuItem";
            this.отчетНаБензинToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.отчетНаБензинToolStripMenuItem.Text = "Отчет на бензин";
            this.отчетНаБензинToolStripMenuItem.Click += new System.EventHandler(this.отчетНаБензинToolStripMenuItem_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUp.Location = new System.Drawing.Point(237, 296);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(92, 35);
            this.BtnUp.TabIndex = 7;
            this.BtnUp.Text = "Переместить вверх";
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDown.Location = new System.Drawing.Point(347, 296);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(92, 35);
            this.BtnDown.TabIndex = 8;
            this.BtnDown.Text = "Переместить вниз";
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(472, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Расход л. на 100км";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Стоимость топлива";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(686, 337);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(61, 20);
            this.TB2.TabIndex = 12;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(812, 337);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(61, 20);
            this.TB3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(737, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // SqliteEditButton
            // 
            this.SqliteEditButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SqliteEditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SqliteEditButton.Location = new System.Drawing.Point(836, 418);
            this.SqliteEditButton.Name = "SqliteEditButton";
            this.SqliteEditButton.Size = new System.Drawing.Size(92, 35);
            this.SqliteEditButton.TabIndex = 15;
            this.SqliteEditButton.Text = "Редактор БД";
            this.SqliteEditButton.UseVisualStyleBackColor = false;
            this.SqliteEditButton.Click += new System.EventHandler(this.SqliteEditButton_Click);
            // 
            // Number
            // 
            this.Number.FillWeight = 40F;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.FillWeight = 70F;
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            // 
            // AdressFrom
            // 
            this.AdressFrom.FillWeight = 80F;
            this.AdressFrom.HeaderText = "Место отправления (компания)";
            this.AdressFrom.Name = "AdressFrom";
            // 
            // CompanyNameFrom
            // 
            this.CompanyNameFrom.HeaderText = "Место отправления (адрес)";
            this.CompanyNameFrom.Name = "CompanyNameFrom";
            // 
            // CompanyNameIn
            // 
            this.CompanyNameIn.FillWeight = 80F;
            this.CompanyNameIn.HeaderText = "Место назначения (компания)";
            this.CompanyNameIn.Name = "CompanyNameIn";
            // 
            // PlaceIn
            // 
            this.PlaceIn.FillWeight = 120F;
            this.PlaceIn.HeaderText = "Место назначения (адрес)";
            this.PlaceIn.Name = "PlaceIn";
            // 
            // DistanceKm
            // 
            this.DistanceKm.FillWeight = 50F;
            this.DistanceKm.HeaderText = "Дистанция";
            this.DistanceKm.Name = "DistanceKm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 465);
            this.Controls.Add(this.SqliteEditButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem путевойЛистToolStripMenuItem;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.ToolStripMenuItem отчетНаБензинToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SqliteEditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceKm;
    }
}

