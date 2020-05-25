namespace restaurantAuto
{
    partial class deleteFromMenu
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
            this.pervoyeCB = new System.Windows.Forms.ComboBox();
            this.okButton = new restaurantAuto.newButton();
            this.cancelButton = new restaurantAuto.newButton();
            this.vtoroyeCB = new System.Windows.Forms.ComboBox();
            this.garnirCB = new System.Windows.Forms.ComboBox();
            this.drinksCB = new System.Windows.Forms.ComboBox();
            this.menuDataSet = new restaurantAuto.menuDataSet();
            this.soupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soupsTableAdapter = new restaurantAuto.menuDataSetTableAdapters.soupsTableAdapter();
            this.menuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondTableAdapter = new restaurantAuto.menuDataSetTableAdapters.secondTableAdapter();
            this.garnirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garnirTableAdapter = new restaurantAuto.menuDataSetTableAdapters.garnirTableAdapter();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinksTableAdapter = new restaurantAuto.menuDataSetTableAdapters.drinksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garnirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите пункт меню";
            // 
            // pervoyeCB
            // 
            this.pervoyeCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soupsBindingSource, "soupName", true));
            this.pervoyeCB.DataSource = this.soupsBindingSource;
            this.pervoyeCB.DisplayMember = "soupName";
            this.pervoyeCB.FormattingEnabled = true;
            this.pervoyeCB.Location = new System.Drawing.Point(38, 74);
            this.pervoyeCB.Name = "pervoyeCB";
            this.pervoyeCB.Size = new System.Drawing.Size(156, 21);
            this.pervoyeCB.TabIndex = 1;
            this.pervoyeCB.ValueMember = "soupName";
            this.pervoyeCB.Visible = false;
            // 
            // okButton
            // 
            this.okButton.BorderColor = System.Drawing.Color.Silver;
            this.okButton.ButtonColor = System.Drawing.Color.Red;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.okButton.Location = new System.Drawing.Point(38, 113);
            this.okButton.Name = "okButton";
            this.okButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.okButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.okButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ок";
            this.okButton.TextColor = System.Drawing.Color.White;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.ButtonColor = System.Drawing.Color.Red;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.Location = new System.Drawing.Point(119, 113);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // vtoroyeCB
            // 
            this.vtoroyeCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.secondBindingSource, "dishName", true));
            this.vtoroyeCB.DataSource = this.secondBindingSource;
            this.vtoroyeCB.DisplayMember = "dishName";
            this.vtoroyeCB.FormattingEnabled = true;
            this.vtoroyeCB.Location = new System.Drawing.Point(38, 74);
            this.vtoroyeCB.Name = "vtoroyeCB";
            this.vtoroyeCB.Size = new System.Drawing.Size(156, 21);
            this.vtoroyeCB.TabIndex = 7;
            this.vtoroyeCB.ValueMember = "dishName";
            this.vtoroyeCB.Visible = false;
            // 
            // garnirCB
            // 
            this.garnirCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.garnirBindingSource, "garnirName", true));
            this.garnirCB.DataSource = this.garnirBindingSource;
            this.garnirCB.DisplayMember = "garnirName";
            this.garnirCB.FormattingEnabled = true;
            this.garnirCB.Location = new System.Drawing.Point(38, 74);
            this.garnirCB.Name = "garnirCB";
            this.garnirCB.Size = new System.Drawing.Size(156, 21);
            this.garnirCB.TabIndex = 8;
            this.garnirCB.ValueMember = "garnirName";
            this.garnirCB.Visible = false;
            // 
            // drinksCB
            // 
            this.drinksCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.drinksBindingSource, "drinkName", true));
            this.drinksCB.DataSource = this.drinksBindingSource;
            this.drinksCB.DisplayMember = "drinkName";
            this.drinksCB.FormattingEnabled = true;
            this.drinksCB.Location = new System.Drawing.Point(38, 74);
            this.drinksCB.Name = "drinksCB";
            this.drinksCB.Size = new System.Drawing.Size(156, 21);
            this.drinksCB.TabIndex = 9;
            this.drinksCB.ValueMember = "drinkName";
            this.drinksCB.Visible = false;
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
            // menuDataSetBindingSource
            // 
            this.menuDataSetBindingSource.DataSource = this.menuDataSet;
            this.menuDataSetBindingSource.Position = 0;
            // 
            // secondBindingSource
            // 
            this.secondBindingSource.DataMember = "second";
            this.secondBindingSource.DataSource = this.menuDataSetBindingSource;
            // 
            // secondTableAdapter
            // 
            this.secondTableAdapter.ClearBeforeFill = true;
            // 
            // garnirBindingSource
            // 
            this.garnirBindingSource.DataMember = "garnir";
            this.garnirBindingSource.DataSource = this.menuDataSetBindingSource;
            // 
            // garnirTableAdapter
            // 
            this.garnirTableAdapter.ClearBeforeFill = true;
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "drinks";
            this.drinksBindingSource.DataSource = this.menuDataSetBindingSource;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // deleteFromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 169);
            this.Controls.Add(this.drinksCB);
            this.Controls.Add(this.garnirCB);
            this.Controls.Add(this.vtoroyeCB);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pervoyeCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteFromMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteFromMenu";
            this.Load += new System.EventHandler(this.deleteFromMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garnirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pervoyeCB;
        private newButton okButton;
        private newButton cancelButton;
        private System.Windows.Forms.ComboBox vtoroyeCB;
        private System.Windows.Forms.ComboBox garnirCB;
        private System.Windows.Forms.ComboBox drinksCB;
        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource soupsBindingSource;
        private menuDataSetTableAdapters.soupsTableAdapter soupsTableAdapter;
        private System.Windows.Forms.BindingSource menuDataSetBindingSource;
        private System.Windows.Forms.BindingSource secondBindingSource;
        private menuDataSetTableAdapters.secondTableAdapter secondTableAdapter;
        private System.Windows.Forms.BindingSource garnirBindingSource;
        private menuDataSetTableAdapters.garnirTableAdapter garnirTableAdapter;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private menuDataSetTableAdapters.drinksTableAdapter drinksTableAdapter;
    }
}