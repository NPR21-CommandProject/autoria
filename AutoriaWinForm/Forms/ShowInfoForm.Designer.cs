namespace AutoriaWinForm.Forms
{
    partial class ShowInfoForm
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
            dgvShowAllInfo = new DataGridView();
            Users = new DataGridViewTextBoxColumn();
            Cars = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllInfo).BeginInit();
            SuspendLayout();
            // 
            // dgvShowAllInfo
            // 
            dgvShowAllInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAllInfo.Columns.AddRange(new DataGridViewColumn[] { Users, Cars });
            dgvShowAllInfo.GridColor = Color.White;
            dgvShowAllInfo.Location = new Point(31, 64);
            dgvShowAllInfo.Name = "dgvShowAllInfo";
            dgvShowAllInfo.Size = new Size(743, 317);
            dgvShowAllInfo.TabIndex = 0;
            // 
            // Users
            // 
            Users.HeaderText = "Users";
            Users.Name = "Users";
            Users.Width = 350;
            // 
            // Cars
            // 
            Cars.HeaderText = "Cars";
            Cars.Name = "Cars";
            Cars.Width = 350;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Show all info menu";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Orange;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(333, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // ShowInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(dgvShowAllInfo);
            Name = "ShowInfoForm";
            Text = "InfoShowForm";
            ((System.ComponentModel.ISupportInitialize)dgvShowAllInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowAllInfo;
        private DataGridViewTextBoxColumn Users;
        private DataGridViewTextBoxColumn Cars;
        private Label label1;
        private Button btnExit;
    }
}