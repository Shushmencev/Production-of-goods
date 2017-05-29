namespace Production_of_goods
{
    partial class FormGoodsList
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
            System.Windows.Forms.Label id_goodsLabel;
            System.Windows.Forms.Label goods_nameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsList));
            System.Windows.Forms.Label photoLabel;
            this.production_of_goodsDataSet = new Production_of_goods.production_of_goodsDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Production_of_goods.production_of_goodsDataSetTableAdapters.goodsTableAdapter();
            this.tableAdapterManager = new Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager();
            this.goodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.goodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_goodsTextBox = new System.Windows.Forms.TextBox();
            this.goods_nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            id_goodsLabel = new System.Windows.Forms.Label();
            goods_nameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).BeginInit();
            this.goodsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // id_goodsLabel
            // 
            id_goodsLabel.AutoSize = true;
            id_goodsLabel.Location = new System.Drawing.Point(6, 25);
            id_goodsLabel.Name = "id_goodsLabel";
            id_goodsLabel.Size = new System.Drawing.Size(50, 13);
            id_goodsLabel.TabIndex = 1;
            id_goodsLabel.Text = "id goods:";
            // 
            // goods_nameLabel
            // 
            goods_nameLabel.AutoSize = true;
            goods_nameLabel.Location = new System.Drawing.Point(6, 51);
            goods_nameLabel.Name = "goods_nameLabel";
            goods_nameLabel.Size = new System.Drawing.Size(68, 13);
            goods_nameLabel.TabIndex = 3;
            goods_nameLabel.Text = "goods name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(6, 77);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "category:";
            // 
            // production_of_goodsDataSet
            // 
            this.production_of_goodsDataSet.DataSetName = "production_of_goodsDataSet";
            this.production_of_goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.production_of_goodsDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.goods_manufacturerTableAdapter = null;
            this.tableAdapterManager.goods_resourceTableAdapter = null;
            this.tableAdapterManager.goodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.manufacturerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.resourceTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Production_of_goods.production_of_goodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // goodsBindingNavigator
            // 
            this.goodsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.goodsBindingNavigator.BindingSource = this.goodsBindingSource;
            this.goodsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goodsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.goodsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.goodsBindingNavigatorSaveItem});
            this.goodsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goodsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goodsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goodsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goodsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goodsBindingNavigator.Name = "goodsBindingNavigator";
            this.goodsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goodsBindingNavigator.Size = new System.Drawing.Size(597, 25);
            this.goodsBindingNavigator.TabIndex = 0;
            this.goodsBindingNavigator.Text = "bindingNavigator1";
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
            // goodsBindingNavigatorSaveItem
            // 
            this.goodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goodsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("goodsBindingNavigatorSaveItem.Image")));
            this.goodsBindingNavigatorSaveItem.Name = "goodsBindingNavigatorSaveItem";
            this.goodsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.goodsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.goodsBindingNavigatorSaveItem.Click += new System.EventHandler(this.goodsBindingNavigatorSaveItem_Click);
            // 
            // id_goodsTextBox
            // 
            this.id_goodsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "id_goods", true));
            this.id_goodsTextBox.Location = new System.Drawing.Point(80, 22);
            this.id_goodsTextBox.Name = "id_goodsTextBox";
            this.id_goodsTextBox.Size = new System.Drawing.Size(130, 20);
            this.id_goodsTextBox.TabIndex = 2;
            // 
            // goods_nameTextBox
            // 
            this.goods_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "goods_name", true));
            this.goods_nameTextBox.Location = new System.Drawing.Point(80, 48);
            this.goods_nameTextBox.Name = "goods_nameTextBox";
            this.goods_nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.goods_nameTextBox.TabIndex = 4;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(80, 74);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(130, 20);
            this.categoryTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_goodsLabel);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(this.id_goodsTextBox);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(goods_nameLabel);
            this.groupBox1.Controls.Add(this.goods_nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(photoLabel);
            this.groupBox2.Controls.Add(this.photoPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(258, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 317);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(6, 25);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(110, 13);
            photoLabel.TabIndex = 0;
            photoLabel.Text = "Фотография товара";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.goodsBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(6, 51);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(315, 260);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Открыть фото";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
            // 
            // FormGoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goodsBindingNavigator);
            this.Name = "FormGoodsList";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FormGoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.production_of_goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).EndInit();
            this.goodsBindingNavigator.ResumeLayout(false);
            this.goodsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private production_of_goodsDataSet production_of_goodsDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private production_of_goodsDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private production_of_goodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator goodsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton goodsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_goodsTextBox;
        private System.Windows.Forms.TextBox goods_nameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}