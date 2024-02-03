namespace AutoriaWinForm
{
    partial class SettingButton
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
            components = new System.ComponentModel.Container();
            DashboardButton = new Button();
            CatalogCarButton = new Button();
            SalesButton = new Button();
            MessegesButton = new Button();
            button1 = new Button();
            SalesChart = new TextBox();
            NumberofSales = new TextBox();
            SalesVolume = new TextBox();
            NumberofUsers = new TextBox();
            categories = new ContextMenuStrip(components);
            addNewCarToolStripMenuItem = new ToolStripMenuItem();
            displayAllInfoToolStripMenuItem = new ToolStripMenuItem();
            addDeleteUserToolStripMenuItem = new ToolStripMenuItem();
            editCarToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            categories.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardButton
            // 
            DashboardButton.Cursor = Cursors.Hand;
            DashboardButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            DashboardButton.Location = new Point(12, 26);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(181, 40);
            DashboardButton.TabIndex = 5;
            DashboardButton.Text = "Dashboard";
            DashboardButton.UseVisualStyleBackColor = true;
            // 
            // CatalogCarButton
            // 
            CatalogCarButton.Cursor = Cursors.Hand;
            CatalogCarButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            CatalogCarButton.Location = new Point(12, 82);
            CatalogCarButton.Name = "CatalogCarButton";
            CatalogCarButton.Size = new Size(181, 40);
            CatalogCarButton.TabIndex = 6;
            CatalogCarButton.Text = "Catalog";
            CatalogCarButton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            SalesButton.Cursor = Cursors.Hand;
            SalesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SalesButton.Location = new Point(12, 145);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(181, 40);
            SalesButton.TabIndex = 7;
            SalesButton.Text = "Sales";
            SalesButton.UseVisualStyleBackColor = true;
            // 
            // MessegesButton
            // 
            MessegesButton.Cursor = Cursors.Hand;
            MessegesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            MessegesButton.Location = new Point(12, 205);
            MessegesButton.Name = "MessegesButton";
            MessegesButton.Size = new Size(181, 40);
            MessegesButton.TabIndex = 8;
            MessegesButton.Text = "Incoming messages";
            MessegesButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(12, 264);
            button1.Name = "button1";
            button1.Size = new Size(181, 40);
            button1.TabIndex = 9;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // SalesChart
            // 
            SalesChart.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SalesChart.Location = new Point(222, 111);
            SalesChart.Multiline = true;
            SalesChart.Name = "SalesChart";
            SalesChart.Size = new Size(423, 193);
            SalesChart.TabIndex = 16;
            SalesChart.Text = "Sales Chart";
            // 
            // NumberofSales
            // 
            NumberofSales.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            NumberofSales.Location = new Point(222, 32);
            NumberofSales.Multiline = true;
            NumberofSales.Name = "NumberofSales";
            NumberofSales.Size = new Size(195, 64);
            NumberofSales.TabIndex = 17;
            NumberofSales.Text = "Number of Sales:";
            // 
            // SalesVolume
            // 
            SalesVolume.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SalesVolume.Location = new Point(450, 32);
            SalesVolume.Multiline = true;
            SalesVolume.Name = "SalesVolume";
            SalesVolume.Size = new Size(195, 61);
            SalesVolume.TabIndex = 18;
            SalesVolume.Text = "Sales Volume:";
            // 
            // NumberofUsers
            // 
            NumberofUsers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            NumberofUsers.Location = new Point(674, 32);
            NumberofUsers.Multiline = true;
            NumberofUsers.Name = "NumberofUsers";
            NumberofUsers.Size = new Size(193, 61);
            NumberofUsers.TabIndex = 19;
            NumberofUsers.Text = "Number of Users:";
            // 
            // categories
            // 
            categories.ImageScalingSize = new Size(20, 20);
            categories.Items.AddRange(new ToolStripItem[] { addNewCarToolStripMenuItem, displayAllInfoToolStripMenuItem, addDeleteUserToolStripMenuItem, editCarToolStripMenuItem, exitToolStripMenuItem });
            categories.Name = "categories";
            categories.Size = new Size(188, 124);
            categories.Text = "Categories";
            // 
            // addNewCarToolStripMenuItem
            // 
            addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            addNewCarToolStripMenuItem.Size = new Size(210, 24);
            addNewCarToolStripMenuItem.Text = "Add new car";
            // 
            // displayAllInfoToolStripMenuItem
            // 
            displayAllInfoToolStripMenuItem.Name = "displayAllInfoToolStripMenuItem";
            displayAllInfoToolStripMenuItem.Size = new Size(210, 24);
            displayAllInfoToolStripMenuItem.Text = "Display all info";
            // 
            // addDeleteUserToolStripMenuItem
            // 
            addDeleteUserToolStripMenuItem.Name = "addDeleteUserToolStripMenuItem";
            addDeleteUserToolStripMenuItem.Size = new Size(210, 24);
            addDeleteUserToolStripMenuItem.Text = "Add/Delete user";
            // 
            // editCarToolStripMenuItem
            // 
            editCarToolStripMenuItem.Name = "editCarToolStripMenuItem";
            editCarToolStripMenuItem.Size = new Size(210, 24);
            editCarToolStripMenuItem.Text = "Edit car";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(210, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // SettingButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(918, 383);
            Controls.Add(NumberofUsers);
            Controls.Add(SalesVolume);
            Controls.Add(NumberofSales);
            Controls.Add(SalesChart);
            Controls.Add(button1);
            Controls.Add(MessegesButton);
            Controls.Add(SalesButton);
            Controls.Add(CatalogCarButton);
            Controls.Add(DashboardButton);
            Name = "SettingButton";
            Text = "AdminWindow";
            categories.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DashboardButton;
        private Button CatalogCarButton;
        private Button SalesButton;
        private Button MessegesButton;
        private Button button1;
        private TextBox SalesChart;
        private TextBox NumberofSales;
        private TextBox SalesVolume;
        private TextBox NumberofUsers;
        private ContextMenuStrip categories;
        private ToolStripMenuItem addNewCarToolStripMenuItem;
        private ToolStripMenuItem displayAllInfoToolStripMenuItem;
        private ToolStripMenuItem addDeleteUserToolStripMenuItem;
        private ToolStripMenuItem editCarToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}