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
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_Orders = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControlSQL.SuspendLayout();
            this.tabPfge1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxCustomerOrder.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPfge1);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
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
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.groupBoxDet);
            this.tabPageSelect.Controls.Add(this.groupBoxCustomerOrder);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(605, 367);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomerOrder
            // 
            this.groupBoxCustomerOrder.Controls.Add(this.textBoxCustomer);
            this.groupBoxCustomerOrder.Controls.Add(this.labelCustomer);
            this.groupBoxCustomerOrder.Location = new System.Drawing.Point(3, 6);
            this.groupBoxCustomerOrder.Name = "groupBoxCustomerOrder";
            this.groupBoxCustomerOrder.Size = new System.Drawing.Size(227, 109);
            this.groupBoxCustomerOrder.TabIndex = 0;
            this.groupBoxCustomerOrder.TabStop = false;
            this.groupBoxCustomerOrder.Text = "Запросы заказчиков";
            this.groupBoxCustomerOrder.Enter += new System.EventHandler(this.groupBoxCustomerOrder_Enter);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(5, 24);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(85, 13);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Имя заказчика";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(8, 40);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(213, 20);
            this.textBoxCustomer.TabIndex = 1;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButton2);
            this.groupBoxDet.Controls.Add(this.radioButton1);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Orders);
            this.groupBoxDet.Location = new System.Drawing.Point(236, 6);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(366, 109);
            this.groupBoxDet.TabIndex = 1;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация запросов";
            // 
            // radioButtonDet_Orders
            // 
            this.radioButtonDet_Orders.AutoSize = true;
            this.radioButtonDet_Orders.Location = new System.Drawing.Point(8, 20);
            this.radioButtonDet_Orders.Name = "radioButtonDet_Orders";
            this.radioButtonDet_Orders.Size = new System.Drawing.Size(182, 17);
            this.radioButtonDet_Orders.TabIndex = 0;
            this.radioButtonDet_Orders.TabStop = true;
            this.radioButtonDet_Orders.Text = "Сумма заказов по категориям";
            this.radioButtonDet_Orders.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(192, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сумма заказов по имени товара";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Нет детализации";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxCustomerOrder.ResumeLayout(false);
            this.groupBoxCustomerOrder.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPfge1;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonResources;
        private System.Windows.Forms.RadioButton radioButtonManufacturers;
        private System.Windows.Forms.RadioButton radioButtonCostomers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxCustomerOrder;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_Orders;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}