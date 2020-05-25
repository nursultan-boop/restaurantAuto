namespace restaurantAuto
{
    partial class Manager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newButton1 = new restaurantAuto.newButton();
            this.newButton2 = new restaurantAuto.newButton();
            this.newButton3 = new restaurantAuto.newButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backPanel.SuspendLayout();
            this.upperBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(543, 3);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.backPanel.Controls.Add(this.newButton1);
            this.backPanel.Controls.Add(this.newButton3);
            this.backPanel.Controls.Add(this.newButton2);
            this.backPanel.Controls.Add(this.tabControl1);
            this.backPanel.Size = new System.Drawing.Size(571, 326);
            // 
            // upperBar
            // 
            this.upperBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(72)))));
            this.upperBar.Size = new System.Drawing.Size(571, 36);
            this.upperBar.Paint += new System.Windows.Forms.PaintEventHandler(this.upperBar_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 326);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Первые блюда";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Основные блюда";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(557, 294);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(507, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Гарнир";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(501, 287);
            this.dataGridView3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(507, 293);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Напитки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(501, 287);
            this.dataGridView4.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(507, 293);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Доходы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(501, 287);
            this.dataGridView5.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Заработок";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // newButton1
            // 
            this.newButton1.AutoEllipsis = true;
            this.newButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton1.BorderColor = System.Drawing.Color.Silver;
            this.newButton1.ButtonColor = System.Drawing.Color.Red;
            this.newButton1.FlatAppearance.BorderSize = 0;
            this.newButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton1.Location = new System.Drawing.Point(451, 103);
            this.newButton1.Name = "newButton1";
            this.newButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton1.Size = new System.Drawing.Size(89, 51);
            this.newButton1.TabIndex = 1;
            this.newButton1.Text = "Добавить новый пункт";
            this.newButton1.TextColor = System.Drawing.Color.White;
            this.newButton1.UseVisualStyleBackColor = false;
            this.newButton1.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // newButton2
            // 
            this.newButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton2.BorderColor = System.Drawing.Color.Silver;
            this.newButton2.ButtonColor = System.Drawing.Color.Red;
            this.newButton2.FlatAppearance.BorderSize = 0;
            this.newButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton2.Location = new System.Drawing.Point(451, 209);
            this.newButton2.Name = "newButton2";
            this.newButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton2.Size = new System.Drawing.Size(89, 50);
            this.newButton2.TabIndex = 2;
            this.newButton2.Text = "Удалить пункт меню";
            this.newButton2.TextColor = System.Drawing.Color.White;
            this.newButton2.UseVisualStyleBackColor = false;
            this.newButton2.Click += new System.EventHandler(this.newButton2_Click);
            // 
            // newButton3
            // 
            this.newButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton3.BorderColor = System.Drawing.Color.Silver;
            this.newButton3.ButtonColor = System.Drawing.Color.Red;
            this.newButton3.FlatAppearance.BorderSize = 0;
            this.newButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton3.Location = new System.Drawing.Point(451, 160);
            this.newButton3.Name = "newButton3";
            this.newButton3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.newButton3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.newButton3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.newButton3.Size = new System.Drawing.Size(89, 43);
            this.newButton3.TabIndex = 3;
            this.newButton3.Text = "Изменить пункт";
            this.newButton3.TextColor = System.Drawing.Color.White;
            this.newButton3.UseVisualStyleBackColor = false;
            this.newButton3.Click += new System.EventHandler(this.newButton3_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 362);
            this.Name = "Manager";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.upperBar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private newButton newButton1;
        private newButton newButton2;
        private newButton newButton3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}