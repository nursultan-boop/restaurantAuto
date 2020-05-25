namespace restaurantAuto
{
    partial class EditUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers1DataSet3 = new restaurantAuto.workers1DataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.newButton1 = new restaurantAuto.newButton();
            this.newButton2 = new restaurantAuto.newButton();
            this.workersTableAdapter = new restaurantAuto.workers1DataSet3TableAdapters.workersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.nameSurnameDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(414, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // nameSurnameDataGridViewTextBoxColumn
            // 
            this.nameSurnameDataGridViewTextBoxColumn.DataPropertyName = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.HeaderText = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.Name = "nameSurnameDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.workers1DataSet3;
            // 
            // workers1DataSet3
            // 
            this.workers1DataSet3.DataSetName = "workers1DataSet3";
            this.workers1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Менеджер",
            "Официант",
            "Администратор"});
            this.comboBox1.Location = new System.Drawing.Point(63, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 6;
            // 
            // newButton1
            // 
            this.newButton1.BackColor = System.Drawing.Color.Transparent;
            this.newButton1.BorderColor = System.Drawing.Color.Silver;
            this.newButton1.ButtonColor = System.Drawing.Color.Red;
            this.newButton1.FlatAppearance.BorderSize = 0;
            this.newButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton1.Location = new System.Drawing.Point(63, 180);
            this.newButton1.Name = "newButton1";
            this.newButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton1.Size = new System.Drawing.Size(75, 23);
            this.newButton1.TabIndex = 7;
            this.newButton1.Text = "Подтвердить";
            this.newButton1.TextColor = System.Drawing.Color.White;
            this.newButton1.UseVisualStyleBackColor = false;
            this.newButton1.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // newButton2
            // 
            this.newButton2.BackColor = System.Drawing.Color.Transparent;
            this.newButton2.BorderColor = System.Drawing.Color.Silver;
            this.newButton2.ButtonColor = System.Drawing.Color.Red;
            this.newButton2.FlatAppearance.BorderSize = 0;
            this.newButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton2.Location = new System.Drawing.Point(154, 180);
            this.newButton2.Name = "newButton2";
            this.newButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton2.Size = new System.Drawing.Size(75, 23);
            this.newButton2.TabIndex = 8;
            this.newButton2.Text = "Отмена";
            this.newButton2.TextColor = System.Drawing.Color.White;
            this.newButton2.UseVisualStyleBackColor = false;
            this.newButton2.Click += new System.EventHandler(this.newButton2_Click);
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.newButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 277);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private newButton newButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private newButton newButton2;
        private workers1DataSet3 workers1DataSet3;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private workers1DataSet3TableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}