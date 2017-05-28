namespace Production_of_goods
{
    partial class FormResourceList
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
            System.Windows.Forms.Label id_resourseLabel;
            System.Windows.Forms.Label id_stockLabel;
            System.Windows.Forms.Label volumeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label resource_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResourceList));
            this.production_of_goodsDataSet = new Production_of_goods.production_of_goodsDataSet();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceTableAdapter = new Production_of_goods.production_of_goodsDataSetTableAdapters.resourceTableAdapter();
            this.tableAdapterManager = new Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager();
            this.resourceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_resourseTextBox = new System.Windows.Forms.TextBox();
            this.id_stockTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.resource_nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.resourceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_resourseLabel = new System.Windows.Forms.Label();
            id_stockLabel = new System.Windows.Forms.Label();
            volumeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            resource_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingNavigator)).BeginInit();
            this.resourceBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // production_of_goodsDataSet
            // 
            this.production_of_goodsDataSet.DataSetName = "production_of_goodsDataSet";
            this.production_of_goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            this.resourceBindingSource.DataSource = this.production_of_goodsDataSet;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.goods_manufacturerTableAdapter = null;
            this.tableAdapterManager.goods_resourceTableAdapter = null;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.manufacturerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.resourceTableAdapter = this.resourceTableAdapter;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resourceBindingNavigator
            // 
            this.resourceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.resourceBindingNavigator.BindingSource = this.resourceBindingSource;
            this.resourceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.resourceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.resourceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.resourceBindingNavigatorSaveItem});
            this.resourceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.resourceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.resourceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.resourceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.resourceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.resourceBindingNavigator.Name = "resourceBindingNavigator";
            this.resourceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.resourceBindingNavigator.Size = new System.Drawing.Size(307, 25);
            this.resourceBindingNavigator.TabIndex = 0;
            this.resourceBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_resourseLabel
            // 
            id_resourseLabel.AutoSize = true;
            id_resourseLabel.Location = new System.Drawing.Point(12, 42);
            id_resourseLabel.Name = "id_resourseLabel";
            id_resourseLabel.Size = new System.Drawing.Size(61, 13);
            id_resourseLabel.TabIndex = 1;
            id_resourseLabel.Text = "id resourse:";
            // 
            // id_resourseTextBox
            // 
            this.id_resourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resourceBindingSource, "id_resourse", true));
            this.id_resourseTextBox.Location = new System.Drawing.Point(98, 39);
            this.id_resourseTextBox.Name = "id_resourseTextBox";
            this.id_resourseTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_resourseTextBox.TabIndex = 2;
            // 
            // id_stockLabel
            // 
            id_stockLabel.AutoSize = true;
            id_stockLabel.Location = new System.Drawing.Point(12, 68);
            id_stockLabel.Name = "id_stockLabel";
            id_stockLabel.Size = new System.Drawing.Size(47, 13);
            id_stockLabel.TabIndex = 3;
            id_stockLabel.Text = "id stock:";
            // 
            // id_stockTextBox
            // 
            this.id_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resourceBindingSource, "id_stock", true));
            this.id_stockTextBox.Location = new System.Drawing.Point(98, 65);
            this.id_stockTextBox.Name = "id_stockTextBox";
            this.id_stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_stockTextBox.TabIndex = 4;
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new System.Drawing.Point(12, 94);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new System.Drawing.Size(44, 13);
            volumeLabel.TabIndex = 5;
            volumeLabel.Text = "volume:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resourceBindingSource, "volume", true));
            this.volumeTextBox.Location = new System.Drawing.Point(98, 91);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.volumeTextBox.TabIndex = 6;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 120);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resourceBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(98, 117);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // resource_nameLabel
            // 
            resource_nameLabel.AutoSize = true;
            resource_nameLabel.Location = new System.Drawing.Point(12, 146);
            resource_nameLabel.Name = "resource_nameLabel";
            resource_nameLabel.Size = new System.Drawing.Size(80, 13);
            resource_nameLabel.TabIndex = 9;
            resource_nameLabel.Text = "resource name:";
            // 
            // resource_nameTextBox
            // 
            this.resource_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resourceBindingSource, "resource_name", true));
            this.resource_nameTextBox.Location = new System.Drawing.Point(98, 143);
            this.resource_nameTextBox.Name = "resource_nameTextBox";
            this.resource_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.resource_nameTextBox.TabIndex = 10;
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
            // resourceBindingNavigatorSaveItem
            // 
            this.resourceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resourceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("resourceBindingNavigatorSaveItem.Image")));
            this.resourceBindingNavigatorSaveItem.Name = "resourceBindingNavigatorSaveItem";
            this.resourceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.resourceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.resourceBindingNavigatorSaveItem.Click += new System.EventHandler(this.resourceBindingNavigatorSaveItem_Click);
            // 
            // FormResourceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 218);
            this.Controls.Add(id_resourseLabel);
            this.Controls.Add(this.id_resourseTextBox);
            this.Controls.Add(id_stockLabel);
            this.Controls.Add(this.id_stockTextBox);
            this.Controls.Add(volumeLabel);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(resource_nameLabel);
            this.Controls.Add(this.resource_nameTextBox);
            this.Controls.Add(this.resourceBindingNavigator);
            this.Name = "FormResourceList";
            this.Text = "Ресурсы";
            this.Load += new System.EventHandler(this.FormResourceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingNavigator)).EndInit();
            this.resourceBindingNavigator.ResumeLayout(false);
            this.resourceBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private production_of_goodsDataSet production_of_goodsDataSet;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private production_of_goodsDataSetTableAdapters.resourceTableAdapter resourceTableAdapter;
        private production_of_goodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator resourceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton resourceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_resourseTextBox;
        private System.Windows.Forms.TextBox id_stockTextBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox resource_nameTextBox;
    }
}