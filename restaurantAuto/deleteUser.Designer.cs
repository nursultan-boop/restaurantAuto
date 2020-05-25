namespace restaurantAuto
{
    partial class deleteUser
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers1DataSet = new restaurantAuto.workers1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.workersTableAdapter = new restaurantAuto.workers1DataSetTableAdapters.workersTableAdapter();
            this.newButton2 = new restaurantAuto.newButton();
            this.newButton1 = new restaurantAuto.newButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workersBindingSource, "nameSurname", true));
            this.comboBox1.DataSource = this.workersBindingSource;
            this.comboBox1.DisplayMember = "nameSurname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "nameSurname";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите пользователя";
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // newButton2
            // 
            this.newButton2.BorderColor = System.Drawing.Color.Silver;
            this.newButton2.ButtonColor = System.Drawing.Color.Red;
            this.newButton2.FlatAppearance.BorderSize = 0;
            this.newButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton2.Location = new System.Drawing.Point(109, 81);
            this.newButton2.Name = "newButton2";
            this.newButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton2.Size = new System.Drawing.Size(75, 23);
            this.newButton2.TabIndex = 18;
            this.newButton2.Text = "Отмена";
            this.newButton2.TextColor = System.Drawing.Color.White;
            this.newButton2.UseVisualStyleBackColor = true;
            this.newButton2.Click += new System.EventHandler(this.newButton2_Click);
            // 
            // newButton1
            // 
            this.newButton1.BorderColor = System.Drawing.Color.Silver;
            this.newButton1.ButtonColor = System.Drawing.Color.Red;
            this.newButton1.FlatAppearance.BorderSize = 0;
            this.newButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton1.Location = new System.Drawing.Point(15, 81);
            this.newButton1.Name = "newButton1";
            this.newButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton1.Size = new System.Drawing.Size(75, 23);
            this.newButton1.TabIndex = 17;
            this.newButton1.Text = "Подтвердить";
            this.newButton1.TextColor = System.Drawing.Color.White;
            this.newButton1.UseVisualStyleBackColor = true;
            this.newButton1.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newButton2);
            this.panel1.Controls.Add(this.newButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 133);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 151);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteUser";
            this.Load += new System.EventHandler(this.deleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers1DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private newButton newButton2;
        private newButton newButton1;
        private workers1DataSet workers1DataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private workers1DataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}