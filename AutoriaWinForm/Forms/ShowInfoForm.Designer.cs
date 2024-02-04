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
            dgvShowAllUsers = new DataGridView();
            Users = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnExit = new Button();
            dgvShowAllCars = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllCars).BeginInit();
            SuspendLayout();
            // 
            // dgvShowAllUsers
            // 
            dgvShowAllUsers.BackgroundColor = Color.Orange;
            dgvShowAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAllUsers.Columns.AddRange(new DataGridViewColumn[] { Users });
            dgvShowAllUsers.GridColor = Color.White;
            dgvShowAllUsers.Location = new Point(23, 37);
            dgvShowAllUsers.Name = "dgvShowAllUsers";
            dgvShowAllUsers.Size = new Size(393, 354);
            dgvShowAllUsers.TabIndex = 0;
            dgvShowAllUsers.CellContentClick += dgvShowAllUsers_CellContentClick;
            // 
            // Users
            // 
            Users.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Users.HeaderText = "Users";
            Users.Name = "Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Show all info menu";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Orange;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(341, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgvShowAllCars
            // 
            dgvShowAllCars.BackgroundColor = Color.Orange;
            dgvShowAllCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAllCars.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvShowAllCars.GridColor = Color.White;
            dgvShowAllCars.Location = new Point(432, 37);
            dgvShowAllCars.Name = "dgvShowAllCars";
            dgvShowAllCars.Size = new Size(394, 354);
            dgvShowAllCars.TabIndex = 3;
            dgvShowAllCars.CellContentClick += dvgShowAllCars_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Cars";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 350;
            // 
            // ShowInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(848, 450);
            Controls.Add(dgvShowAllCars);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(dgvShowAllUsers);
            Name = "ShowInfoForm";
            Text = "InfoShowForm";
            ((System.ComponentModel.ISupportInitialize)dgvShowAllUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowAllUsers;
        private Label label1;
        private Button btnExit;
        private DataGridView dgvShowAllCars;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Users;
    }
}