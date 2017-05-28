namespace Production_of_goods
{
    partial class FormManufacturersList
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
            System.Windows.Forms.Label id_manufacturerLabel;
            System.Windows.Forms.Label organization_nameLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManufacturersList));
            this.manufacturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.production_of_goodsDataSet = new Production_of_goods.production_of_goodsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manufacturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.organization_nameTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTableAdapter = new Production_of_goods.production_of_goodsDataSetTableAdapters.manufacturerTableAdapter();
            this.tableAdapterManager = new Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter1 = new Production_of_goods.production_of_goodsDataSetTableAdapters.customerTableAdapter();
            this.goods_manufacturerTableAdapter1 = new Production_of_goods.production_of_goodsDataSetTableAdapters.goods_manufacturerTableAdapter();
            this.manufacturerTableAdapter1 = new Production_of_goods.production_of_goodsDataSetTableAdapters.manufacturerTableAdapter();
            id_manufacturerLabel = new System.Windows.Forms.Label();
            organization_nameLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).BeginInit();
            this.manufacturerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_manufacturerLabel
            // 
            id_manufacturerLabel.AutoSize = true;
            id_manufacturerLabel.Location = new System.Drawing.Point(12, 41);
            id_manufacturerLabel.Name = "id_manufacturerLabel";
            id_manufacturerLabel.Size = new System.Drawing.Size(83, 13);
            id_manufacturerLabel.TabIndex = 1;
            id_manufacturerLabel.Text = "id manufacturer:";
            // 
            // organization_nameLabel
            // 
            organization_nameLabel.AutoSize = true;
            organization_nameLabel.Location = new System.Drawing.Point(12, 67);
            organization_nameLabel.Name = "organization_nameLabel";
            organization_nameLabel.Size = new System.Drawing.Size(96, 13);
            organization_nameLabel.TabIndex = 3;
            organization_nameLabel.Text = "organization name:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(12, 93);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(37, 13);
            e_mailLabel.TabIndex = 5;
            e_mailLabel.Text = "e mail:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(12, 119);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(78, 13);
            phone_numberLabel.TabIndex = 7;
            phone_numberLabel.Text = "phone number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 145);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "address:";
            // 
            // manufacturerBindingNavigator
            // 
            this.manufacturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturerBindingNavigator.BindingSource = this.manufacturerBindingSource;
            this.manufacturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.manufacturerBindingNavigatorSaveItem});
            this.manufacturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturerBindingNavigator.Name = "manufacturerBindingNavigator";
            this.manufacturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturerBindingNavigator.Size = new System.Drawing.Size(340, 25);
            this.manufacturerBindingNavigator.TabIndex = 0;
            this.manufacturerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "manufacturer";
            this.manufacturerBindingSource.DataSource = this.production_of_goodsDataSet;
            // 
            // production_of_goodsDataSet
            // 
            this.production_of_goodsDataSet.DataSetName = "production_of_goodsDataSet";
            this.production_of_goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // manufacturerBindingNavigatorSaveItem
            // 
            this.manufacturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturerBindingNavigatorSaveItem.Image")));
            this.manufacturerBindingNavigatorSaveItem.Name = "manufacturerBindingNavigatorSaveItem";
            this.manufacturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manufacturerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.manufacturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturerBindingNavigatorSaveItem_Click);
            // 
            // id_manufacturerTextBox
            // 
            this.id_manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "id_manufacturer", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.id_manufacturerTextBox.Location = new System.Drawing.Point(114, 38);
            this.id_manufacturerTextBox.Name = "id_manufacturerTextBox";
            this.id_manufacturerTextBox.Size = new System.Drawing.Size(161, 20);
            this.id_manufacturerTextBox.TabIndex = 2;
            // 
            // organization_nameTextBox
            // 
            this.organization_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "organization_name", true));
            this.organization_nameTextBox.Location = new System.Drawing.Point(114, 64);
            this.organization_nameTextBox.Name = "organization_nameTextBox";
            this.organization_nameTextBox.Size = new System.Drawing.Size(161, 20);
            this.organization_nameTextBox.TabIndex = 4;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "e_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(114, 90);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(161, 20);
            this.e_mailTextBox.TabIndex = 6;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "phone_number", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.phone_numberTextBox.Location = new System.Drawing.Point(114, 116);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(161, 20);
            this.phone_numberTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(114, 142);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(161, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.goods_manufacturerTableAdapter = null;
            this.tableAdapterManager.goods_resourceTableAdapter = null;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.manufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.resourceTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // goods_manufacturerTableAdapter1
            // 
            this.goods_manufacturerTableAdapter1.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter1
            // 
            this.manufacturerTableAdapter1.ClearBeforeFill = true;
            // 
            // FormManufacturersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 174);
            this.Controls.Add(id_manufacturerLabel);
            this.Controls.Add(this.id_manufacturerTextBox);
            this.Controls.Add(organization_nameLabel);
            this.Controls.Add(this.organization_nameTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.manufacturerBindingNavigator);
            this.Name = "FormManufacturersList";
            this.Text = "Производители";
            this.Load += new System.EventHandler(this.FormManufacturersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).EndInit();
            this.manufacturerBindingNavigator.ResumeLayout(false);
            this.manufacturerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private production_of_goodsDataSet production_of_goodsDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private production_of_goodsDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter;
        private production_of_goodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton manufacturerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_manufacturerTextBox;
        private System.Windows.Forms.TextBox organization_nameTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private production_of_goodsDataSetTableAdapters.customerTableAdapter customerTableAdapter1;
        private production_of_goodsDataSetTableAdapters.goods_manufacturerTableAdapter goods_manufacturerTableAdapter1;
        private production_of_goodsDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter1;
    }
}