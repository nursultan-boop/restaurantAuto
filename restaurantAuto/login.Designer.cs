namespace restaurantAuto
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.acceptButton = new restaurantAuto.newButton();
            this.loginText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers1DataSet = new restaurantAuto.workers1DataSet();
            this.workersTableAdapter = new restaurantAuto.workers1DataSetTableAdapters.workersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backPanel.SuspendLayout();
            this.upperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(242, 3);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.backPanel.Controls.Add(this.dataGridView1);
            this.backPanel.Controls.Add(this.loginText);
            this.backPanel.Controls.Add(this.acceptButton);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Size = new System.Drawing.Size(270, 209);
            this.backPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backPanel_Paint);
            // 
            // upperBar
            // 
            this.upperBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(72)))));
            this.upperBar.Size = new System.Drawing.Size(270, 36);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Transparent;
            this.acceptButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(72)))));
            this.acceptButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(95, 128);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(72)))));
            this.acceptButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.acceptButton.OnHoverTextColor = System.Drawing.Color.White;
            this.acceptButton.Size = new System.Drawing.Size(82, 27);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Ок";
            this.acceptButton.TextColor = System.Drawing.Color.White;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // loginText
            // 
            this.loginText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.loginText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.loginText.Location = new System.Drawing.Point(45, 86);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(181, 20);
            this.loginText.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSurnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(364, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(182, 102);
            this.dataGridView1.TabIndex = 6;
            // 
            // nameSurnameDataGridViewTextBoxColumn
            // 
            this.nameSurnameDataGridViewTextBoxColumn.DataPropertyName = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.HeaderText = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.Name = "nameSurnameDataGridViewTextBoxColumn";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.workers1DataSet;
            // 
            // workers1DataSet
            // 
            this.workers1DataSet.DataSetName = "workers1DataSet";
            this.workers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // login
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(270, 245);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.upperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private newButton acceptButton;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private workers1DataSet workers1DataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private workers1DataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
    }
}