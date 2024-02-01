namespace AutoriaWinForm.Forms
{
    partial class AddNewInformationForm
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
            label1 = new Label();
            vehicleTipeBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label7 = new Label();
            comboBox5 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 47);
            label1.TabIndex = 0;
            label1.Text = "Information menu";
            // 
            // vehicleTipeBox
            // 
            vehicleTipeBox.AccessibleName = "";
            vehicleTipeBox.DisplayMember = "All types of vehicles";
            vehicleTipeBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            vehicleTipeBox.ForeColor = Color.Gray;
            vehicleTipeBox.FormattingEnabled = true;
            vehicleTipeBox.Items.AddRange(new object[] { "Add a new vehicle type", "Delete a vehicle type", "Change the vehicle type" });
            vehicleTipeBox.Location = new Point(12, 91);
            vehicleTipeBox.Name = "vehicleTipeBox";
            vehicleTipeBox.Size = new Size(320, 23);
            vehicleTipeBox.TabIndex = 3;
            vehicleTipeBox.Text = "Vehicle type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 4;
            label2.Text = "Vehicle information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(180, 21);
            label3.TabIndex = 6;
            label3.Text = "Car brand information";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "";
            comboBox1.DisplayMember = "All types of vehicles";
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add a new car brand", "Delete a car brand", "Change the car brand" });
            comboBox1.Location = new Point(12, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Car brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(184, 21);
            label4.TabIndex = 8;
            label4.Text = "Car model information";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "";
            comboBox2.DisplayMember = "All types of vehicles";
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox2.ForeColor = Color.Gray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Add a new car model", "Delete a car model", "Change the car model" });
            comboBox2.Location = new Point(12, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(320, 23);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Car model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(241, 21);
            label5.TabIndex = 10;
            label5.Text = "Year of manufacture of the car";
            // 
            // comboBox3
            // 
            comboBox3.AccessibleName = "";
            comboBox3.DisplayMember = "All types of vehicles";
            comboBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox3.ForeColor = Color.Gray;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Add a new year of manufacture ", "Delete a year of manufacture ", "Change the year of manufacture " });
            comboBox3.Location = new Point(12, 243);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(320, 23);
            comboBox3.TabIndex = 9;
            comboBox3.Text = "Year of manufacture ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 270);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 12;
            label6.Text = "Fuel type";
            // 
            // comboBox4
            // 
            comboBox4.AccessibleName = "";
            comboBox4.DisplayMember = "All types of vehicles";
            comboBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox4.ForeColor = Color.Gray;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Add a new fuel type", "Delete a fuel type", "Change the fuel type" });
            comboBox4.Location = new Point(12, 294);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(320, 23);
            comboBox4.TabIndex = 11;
            comboBox4.Text = "Fuel type";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnConfirm.ForeColor = Color.Green;
            btnConfirm.Location = new Point(12, 403);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(123, 44);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(209, 403);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 16;
            label7.Text = "Engine size";
            // 
            // comboBox5
            // 
            comboBox5.AccessibleName = "";
            comboBox5.DisplayMember = "All types of vehicles";
            comboBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox5.ForeColor = Color.Gray;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Add a new Engine size", "Delete a Engine size", "Change the Engine size" });
            comboBox5.Location = new Point(12, 348);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(320, 23);
            comboBox5.TabIndex = 15;
            comboBox5.Text = "Engine size";
            // 
            // AddNewInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(389, 530);
            Controls.Add(label7);
            Controls.Add(comboBox5);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label6);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(vehicleTipeBox);
            Controls.Add(label1);
            Name = "AddNewInformationForm";
            Text = "AddNewInformationForm";
            Load += AddNewInformationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox vehicleTipeBox;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label7;
        private ComboBox comboBox5;
    }
}