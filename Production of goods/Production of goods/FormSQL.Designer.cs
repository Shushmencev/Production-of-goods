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
            this.components = new System.ComponentModel.Container();
            this.tabPageDML = new System.Windows.Forms.TabControl();
            this.tabPfge1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonCostomers = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturers = new System.Windows.Forms.RadioButton();
            this.radioButtonResources = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.checkBoxSum = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Name = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Cat = new System.Windows.Forms.RadioButton();
            this.groupBoxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.buttonF_Select = new System.Windows.Forms.Button();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.production_of_goodsDataSet = new Production_of_goods.production_of_goodsDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdResource = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResourceName = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdStock = new System.Windows.Forms.TextBox();
            this.tabPageDML.SuspendLayout();
            this.tabPfge1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxDet.SuspendLayout();
            this.groupBoxCustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.tabPfge1);
            this.tabPageDML.Controls.Add(this.tabPageSelect);
            this.tabPageDML.Controls.Add(this.tabPage1);
            this.tabPageDML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageDML.Location = new System.Drawing.Point(0, 0);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.SelectedIndex = 0;
            this.tabPageDML.Size = new System.Drawing.Size(613, 475);
            this.tabPageDML.TabIndex = 0;
            // 
            // tabPfge1
            // 
            this.tabPfge1.Controls.Add(this.dataGridViewSelect);
            this.tabPfge1.Controls.Add(this.groupBoxSelect);
            this.tabPfge1.Location = new System.Drawing.Point(4, 22);
            this.tabPfge1.Name = "tabPfge1";
            this.tabPfge1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPfge1.Size = new System.Drawing.Size(605, 449);
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
            this.dataGridViewSelect.Size = new System.Drawing.Size(599, 393);
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
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxDet);
            this.tabPageSelect.Controls.Add(this.groupBoxCustomerOrder);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(605, 449);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 164);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(599, 282);
            this.dataGridViewFSelect.TabIndex = 2;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.checkBoxSum);
            this.groupBoxDet.Controls.Add(this.textBoxMore);
            this.groupBoxDet.Controls.Add(this.checkBoxMore);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Name);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Cat);
            this.groupBoxDet.Location = new System.Drawing.Point(236, 6);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(366, 152);
            this.groupBoxDet.TabIndex = 1;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация заказов";
            // 
            // checkBoxSum
            // 
            this.checkBoxSum.AutoSize = true;
            this.checkBoxSum.Location = new System.Drawing.Point(8, 129);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(252, 17);
            this.checkBoxSum.TabIndex = 5;
            this.checkBoxSum.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxSum.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(155, 104);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(205, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(8, 106);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(141, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать суммы более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(8, 66);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            this.radioButtonDet_NO.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonDet_Name
            // 
            this.radioButtonDet_Name.AutoSize = true;
            this.radioButtonDet_Name.Location = new System.Drawing.Point(8, 43);
            this.radioButtonDet_Name.Name = "radioButtonDet_Name";
            this.radioButtonDet_Name.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDet_Name.TabIndex = 1;
            this.radioButtonDet_Name.TabStop = true;
            this.radioButtonDet_Name.Text = "Ресурсы по";
            this.radioButtonDet_Name.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Cat
            // 
            this.radioButtonDet_Cat.AutoSize = true;
            this.radioButtonDet_Cat.Location = new System.Drawing.Point(8, 20);
            this.radioButtonDet_Cat.Name = "radioButtonDet_Cat";
            this.radioButtonDet_Cat.Size = new System.Drawing.Size(119, 17);
            this.radioButtonDet_Cat.TabIndex = 0;
            this.radioButtonDet_Cat.TabStop = true;
            this.radioButtonDet_Cat.Text = "Ресурсы по имени";
            this.radioButtonDet_Cat.UseVisualStyleBackColor = true;
            this.radioButtonDet_Cat.CheckedChanged += new System.EventHandler(this.radioButtonDet_Cat_CheckedChanged);
            // 
            // groupBoxCustomerOrder
            // 
            this.groupBoxCustomerOrder.Controls.Add(this.buttonF_Select);
            this.groupBoxCustomerOrder.Controls.Add(this.textBoxCustomer);
            this.groupBoxCustomerOrder.Controls.Add(this.labelCustomer);
            this.groupBoxCustomerOrder.Location = new System.Drawing.Point(3, 6);
            this.groupBoxCustomerOrder.Name = "groupBoxCustomerOrder";
            this.groupBoxCustomerOrder.Size = new System.Drawing.Size(227, 152);
            this.groupBoxCustomerOrder.TabIndex = 0;
            this.groupBoxCustomerOrder.TabStop = false;
            this.groupBoxCustomerOrder.Text = "Заказы клиента";
            this.groupBoxCustomerOrder.Enter += new System.EventHandler(this.groupBoxCustomerOrder_Enter);
            // 
            // buttonF_Select
            // 
            this.buttonF_Select.Location = new System.Drawing.Point(8, 104);
            this.buttonF_Select.Name = "buttonF_Select";
            this.buttonF_Select.Size = new System.Drawing.Size(120, 42);
            this.buttonF_Select.TabIndex = 2;
            this.buttonF_Select.Text = "Заказы клиента";
            this.buttonF_Select.UseVisualStyleBackColor = true;
            this.buttonF_Select.Click += new System.EventHandler(this.buttonF_Select_Click);
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(8, 40);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(213, 20);
            this.textBoxCustomer.TabIndex = 1;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(6, 22);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(73, 13);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Имя ресурса";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.production_of_goodsDataSet;
            this.bindingSource2.Position = 0;
            // 
            // production_of_goodsDataSet
            // 
            this.production_of_goodsDataSet.DataSetName = "production_of_goodsDataSet";
            this.production_of_goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 449);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Запросы изменения данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIdResource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtonDelete);
            this.groupBox1.Controls.Add(this.radioButtonUpdate);
            this.groupBox1.Controls.Add(this.radioButtonInsert);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 368);
            this.dataGridView1.TabIndex = 3;
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(7, 20);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(116, 17);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Добавить данные";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.radioButtonInsert_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(130, 20);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(117, 17);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить данные";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(254, 20);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(109, 17);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить данные";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить запрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "id Ресурса";
            // 
            // textBoxIdResource
            // 
            this.textBoxIdResource.Location = new System.Drawing.Point(86, 43);
            this.textBoxIdResource.Name = "textBoxIdResource";
            this.textBoxIdResource.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdResource.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBoxIdStock);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.textBoxPrice);
            this.panel.Controls.Add(this.textBoxVolume);
            this.panel.Controls.Add(this.textBoxResourceName);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(3, 78);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(599, 198);
            this.panel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "resourse_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Объём";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // textBoxResourceName
            // 
            this.textBoxResourceName.Location = new System.Drawing.Point(86, 13);
            this.textBoxResourceName.Name = "textBoxResourceName";
            this.textBoxResourceName.Size = new System.Drawing.Size(100, 20);
            this.textBoxResourceName.TabIndex = 6;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(86, 72);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolume.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(86, 100);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "id_stock";
            // 
            // textBoxIdStock
            // 
            this.textBoxIdStock.Location = new System.Drawing.Point(86, 42);
            this.textBoxIdStock.Name = "textBoxIdStock";
            this.textBoxIdStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdStock.TabIndex = 13;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 475);
            this.Controls.Add(this.tabPageDML);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.tabPageDML.ResumeLayout(false);
            this.tabPfge1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.groupBoxCustomerOrder.ResumeLayout(false);
            this.groupBoxCustomerOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageDML;
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
        private System.Windows.Forms.RadioButton radioButtonDet_Cat;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Name;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.CheckBox checkBoxSum;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.Button buttonF_Select;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private production_of_goodsDataSet production_of_goodsDataSet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdResource;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxResourceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIdStock;
        private System.Windows.Forms.Label label5;
    }
}