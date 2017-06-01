namespace Production_of_goods
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPfge1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonCostomers = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturers = new System.Windows.Forms.RadioButton();
            this.radioButtonResources = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlSQL.SuspendLayout();
            this.tabPfge1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPfge1);
            this.tabControlSQL.Controls.Add(this.tabPage2);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(613, 393);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPfge1
            // 
            this.tabPfge1.Controls.Add(this.dataGridViewSelect);
            this.tabPfge1.Controls.Add(this.groupBoxSelect);
            this.tabPfge1.Location = new System.Drawing.Point(4, 22);
            this.tabPfge1.Name = "tabPfge1";
            this.tabPfge1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPfge1.Size = new System.Drawing.Size(605, 367);
            this.tabPfge1.TabIndex = 0;
            this.tabPfge1.Text = "Пример запросов";
            this.tabPfge1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(599, 311);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonCostomers);
            this.groupBoxSelect.Controls.Add(this.radioButtonManufacturers);
            this.groupBoxSelect.Controls.Add(this.radioButtonResources);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(599, 50);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonCostomers
            // 
            this.radioButtonCostomers.AutoSize = true;
            this.radioButtonCostomers.Location = new System.Drawing.Point(192, 19);
            this.radioButtonCostomers.Name = "radioButtonCostomers";
            this.radioButtonCostomers.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCostomers.TabIndex = 2;
            this.radioButtonCostomers.TabStop = true;
            this.radioButtonCostomers.Text = "Заказчики";
            this.radioButtonCostomers.UseVisualStyleBackColor = true;
            this.radioButtonCostomers.CheckedChanged += new System.EventHandler(this.radioButtonCostomers_CheckedChanged);
            // 
            // radioButtonManufacturers
            // 
            this.radioButtonManufacturers.AutoSize = true;
            this.radioButtonManufacturers.Location = new System.Drawing.Point(82, 20);
            this.radioButtonManufacturers.Name = "radioButtonManufacturers";
            this.radioButtonManufacturers.Size = new System.Drawing.Size(104, 17);
            this.radioButtonManufacturers.TabIndex = 1;
            this.radioButtonManufacturers.TabStop = true;
            this.radioButtonManufacturers.Text = "Производители";
            this.radioButtonManufacturers.UseVisualStyleBackColor = true;
            this.radioButtonManufacturers.CheckedChanged += new System.EventHandler(this.radioButtonManufacturers_CheckedChanged);
            // 
            // radioButtonResources
            // 
            this.radioButtonResources.AutoSize = true;
            this.radioButtonResources.Location = new System.Drawing.Point(7, 20);
            this.radioButtonResources.Name = "radioButtonResources";
            this.radioButtonResources.Size = new System.Drawing.Size(69, 17);
            this.radioButtonResources.TabIndex = 0;
            this.radioButtonResources.TabStop = true;
            this.radioButtonResources.Text = "Ресурсы";
            this.radioButtonResources.UseVisualStyleBackColor = true;
            this.radioButtonResources.CheckedChanged += new System.EventHandler(this.radioButtonResources_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 393);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPfge1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPfge1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonResources;
        private System.Windows.Forms.RadioButton radioButtonManufacturers;
        private System.Windows.Forms.RadioButton radioButtonCostomers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
    }
}