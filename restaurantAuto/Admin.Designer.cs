namespace restaurantAuto
{
    partial class Admin
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
            this.nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers1DataSet1 = new restaurantAuto.workers1DataSet1();
            this.workersTableAdapter = new restaurantAuto.workers1DataSet1TableAdapters.workersTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newButton1 = new restaurantAuto.newButton();
            this.newButton2 = new restaurantAuto.newButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backPanel.SuspendLayout();
            this.upperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(539, 3);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.backPanel.Controls.Add(this.newButton2);
            this.backPanel.Controls.Add(this.newButton1);
            this.backPanel.Controls.Add(this.flowLayoutPanel1);
            this.backPanel.Controls.Add(this.dataGridView1);
            this.backPanel.Size = new System.Drawing.Size(567, 256);
            // 
            // upperBar
            // 
            this.upperBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(72)))));
            this.upperBar.Size = new System.Drawing.Size(567, 36);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSurnameDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(647, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.workersBindingSource.DataSource = this.workers1DataSet1BindingSource;
            // 
            // workers1DataSet1BindingSource
            // 
            this.workers1DataSet1BindingSource.DataSource = this.workers1DataSet1;
            this.workers1DataSet1BindingSource.Position = 0;
            // 
            // workers1DataSet1
            // 
            this.workers1DataSet1.DataSetName = "workers1DataSet1";
            this.workers1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 256);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // newButton1
            // 
            this.newButton1.BorderColor = System.Drawing.Color.Silver;
            this.newButton1.ButtonColor = System.Drawing.Color.Red;
            this.newButton1.FlatAppearance.BorderSize = 0;
            this.newButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton1.Location = new System.Drawing.Point(272, 209);
            this.newButton1.Name = "newButton1";
            this.newButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.newButton1.Size = new System.Drawing.Size(142, 35);
            this.newButton1.TabIndex = 1;
            this.newButton1.Text = "добавить пользователя";
            this.newButton1.TextColor = System.Drawing.Color.White;
            this.newButton1.UseVisualStyleBackColor = true;
            this.newButton1.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // newButton2
            // 
            this.newButton2.BorderColor = System.Drawing.Color.Silver;
            this.newButton2.ButtonColor = System.Drawing.Color.Red;
            this.newButton2.FlatAppearance.BorderSize = 0;
            this.newButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton2.Location = new System.Drawing.Point(420, 209);
            this.newButton2.Name = "newButton2";
            this.newButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.newButton2.Size = new System.Drawing.Size(135, 35);
            this.newButton2.TabIndex = 2;
            this.newButton2.Text = "удалить пользователя";
            this.newButton2.TextColor = System.Drawing.Color.White;
            this.newButton2.UseVisualStyleBackColor = true;
            this.newButton2.Click += new System.EventHandler(this.newButton2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 292);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.upperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource workers1DataSet1BindingSource;
        private workers1DataSet1 workers1DataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private workers1DataSet1TableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private newButton newButton1;
        private newButton newButton2;
    }
}