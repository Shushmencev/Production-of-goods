﻿namespace Production_of_goods
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ресурсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ресурсыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(527, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Выход;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Информация;
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.информацияToolStripMenuItem.Text = "О программе";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.ресурсыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникиToolStripMenuItem.Text = "Справочник";
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Производители;
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.производителиToolStripMenuItem.Text = "Производители";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Товары;
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // ресурсыToolStripMenuItem
            // 
            this.ресурсыToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Ресурсы;
            this.ресурсыToolStripMenuItem.Name = "ресурсыToolStripMenuItem";
            this.ресурсыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.ресурсыToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ресурсыToolStripMenuItem.Text = "Ресурсы";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справочникToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(143, 48);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::Production_of_goods.Properties.Resources.Выход;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Production_of_goods.Properties.Resources.Информация;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителиToolStripMenuItem1,
            this.товарыToolStripMenuItem1,
            this.ресурсыToolStripMenuItem1});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // производителиToolStripMenuItem1
            // 
            this.производителиToolStripMenuItem1.Image = global::Production_of_goods.Properties.Resources.Производители;
            this.производителиToolStripMenuItem1.Name = "производителиToolStripMenuItem1";
            this.производителиToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.производителиToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.производителиToolStripMenuItem1.Text = "Производители";
            // 
            // товарыToolStripMenuItem1
            // 
            this.товарыToolStripMenuItem1.Image = global::Production_of_goods.Properties.Resources.Товары;
            this.товарыToolStripMenuItem1.Name = "товарыToolStripMenuItem1";
            this.товарыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.товарыToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.товарыToolStripMenuItem1.Text = "Товары";
            // 
            // ресурсыToolStripMenuItem1
            // 
            this.ресурсыToolStripMenuItem1.Image = global::Production_of_goods.Properties.Resources.Ресурсы;
            this.ресурсыToolStripMenuItem1.Name = "ресурсыToolStripMenuItem1";
            this.ресурсыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.ресурсыToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.ресурсыToolStripMenuItem1.Text = "Ресурсы";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 267);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Производство товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ресурсыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ресурсыToolStripMenuItem1;
    }
}

