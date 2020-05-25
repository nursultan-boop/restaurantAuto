namespace restaurantAuto
{
    partial class changeMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new restaurantAuto.newButton();
            this.okButton = new restaurantAuto.newButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuDataSet = new restaurantAuto.menuDataSet();
            this.soupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soupsTableAdapter = new restaurantAuto.menuDataSetTableAdapters.soupsTableAdapter();
            this.secondBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondTableAdapter = new restaurantAuto.menuDataSetTableAdapters.secondTableAdapter();
            this.garnirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garnirTableAdapter = new restaurantAuto.menuDataSetTableAdapters.garnirTableAdapter();
            this.drinksTableAdapter = new restaurantAuto.menuDataSetTableAdapters.drinksTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backPanel.SuspendLayout();
            this.upperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garnirBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(399, 3);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.backPanel.Controls.Add(this.button1);
            this.backPanel.Controls.Add(this.cancelButton);
            this.backPanel.Controls.Add(this.okButton);
            this.backPanel.Controls.Add(this.textBox2);
            this.backPanel.Controls.Add(this.label5);
            this.backPanel.Controls.Add(this.pictureBox2);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.numericUpDown1);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.textBox1);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.comboBox1);
            this.backPanel.Size = new System.Drawing.Size(427, 289);
            // 
            // upperBar
            // 
            this.upperBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.upperBar.Controls.Add(this.panel1);
            this.upperBar.Size = new System.Drawing.Size(427, 36);
            this.upperBar.Controls.SetChildIndex(this.pictureBox1, 0);
            this.upperBar.Controls.SetChildIndex(this.panel1, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Выбрать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.ButtonColor = System.Drawing.Color.Red;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(310, 234);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.newButton3_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderColor = System.Drawing.Color.Silver;
            this.okButton.ButtonColor = System.Drawing.Color.Red;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(210, 234);
            this.okButton.Name = "okButton";
            this.okButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.okButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.okButton.OnHoverTextColor = System.Drawing.Color.White;
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 23;
            this.okButton.Text = "Подтвердить";
            this.okButton.TextColor = System.Drawing.Color.White;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 60);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Состав блюда";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::restaurantAuto.Properties.Resources.image;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(225, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Изображение";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 146);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Наименование блюда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите блюдо";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.drinksBindingSource;
            this.comboBox1.DisplayMember = "soupName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "soupName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "drinks";
            this.drinksBindingSource.DataSource = this.menuDataSet;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "menuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soupsBindingSource
            // 
            this.soupsBindingSource.DataMember = "soups";
            this.soupsBindingSource.DataSource = this.menuDataSet;
            // 
            // soupsTableAdapter
            // 
            this.soupsTableAdapter.ClearBeforeFill = true;
            // 
            // secondBindingSource
            // 
            this.secondBindingSource.DataMember = "second";
            this.secondBindingSource.DataSource = this.menuDataSet;
            // 
            // secondTableAdapter
            // 
            this.secondTableAdapter.ClearBeforeFill = true;
            // 
            // garnirBindingSource
            // 
            this.garnirBindingSource.DataMember = "garnir";
            this.garnirBindingSource.DataSource = this.menuDataSet;
            // 
            // garnirTableAdapter
            // 
            this.garnirTableAdapter.ClearBeforeFill = true;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 36);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Изменение пункта меню";
            // 
            // changeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 325);
            this.Name = "changeMenu";
            this.Text = "changeMenu";
            this.Load += new System.EventHandler(this.changeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.upperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garnirBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private newButton cancelButton;
        private newButton okButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource soupsBindingSource;
        private menuDataSetTableAdapters.soupsTableAdapter soupsTableAdapter;
        private System.Windows.Forms.BindingSource secondBindingSource;
        private menuDataSetTableAdapters.secondTableAdapter secondTableAdapter;
        private System.Windows.Forms.BindingSource garnirBindingSource;
        private menuDataSetTableAdapters.garnirTableAdapter garnirTableAdapter;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private menuDataSetTableAdapters.drinksTableAdapter drinksTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}