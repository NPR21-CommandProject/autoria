namespace AutoriaWinForm.Forms
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            txtBoxPhotoDecription = new TextBox();
            vehicleTipeBox = new ComboBox();
            label1 = new Label();
            vehicleMarkBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            vehicleModelBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBoxCarDecription = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtBoxPrice = new TextBox();
            txtBoxOdometer = new TextBox();
            txtBoxCapacity = new TextBox();
            txtBoxFuelType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxPhotoDecription
            // 
            txtBoxPhotoDecription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxPhotoDecription.ForeColor = Color.Gray;
            txtBoxPhotoDecription.Location = new Point(392, 117);
            txtBoxPhotoDecription.Multiline = true;
            txtBoxPhotoDecription.Name = "txtBoxPhotoDecription";
            txtBoxPhotoDecription.Size = new Size(775, 184);
            txtBoxPhotoDecription.TabIndex = 1;
            txtBoxPhotoDecription.Text = "Photo decription";
            txtBoxPhotoDecription.Click += txtBoxPhotoDecription_Click;
            txtBoxPhotoDecription.TextChanged += txtPhotoDescription_TextChanged_1;
            // 
            // vehicleTipeBox
            // 
            vehicleTipeBox.AccessibleName = "";
            vehicleTipeBox.DisplayMember = "All types of vehicles";
            vehicleTipeBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            vehicleTipeBox.ForeColor = Color.Gray;
            vehicleTipeBox.FormattingEnabled = true;
            vehicleTipeBox.Items.AddRange(new object[] { "Passenger cars", "", "Motorcycles", "", "Trucks", "", "Trailers", "", "Special equipment", "", "Agricultural machinery", "", "Buses", "", "Water transport", "", "Air transport", "", "Motor homes" });
            vehicleTipeBox.Location = new Point(34, 294);
            vehicleTipeBox.Name = "vehicleTipeBox";
            vehicleTipeBox.Size = new Size(273, 23);
            vehicleTipeBox.TabIndex = 2;
            vehicleTipeBox.Text = "All vehicle";
            vehicleTipeBox.SelectedIndexChanged += vehicleTipeBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 270);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 3;
            label1.Text = "Vehicle type";
            label1.Click += label1_Click;
            // 
            // vehicleMarkBox
            // 
            vehicleMarkBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            vehicleMarkBox.ForeColor = Color.Gray;
            vehicleMarkBox.FormattingEnabled = true;
            vehicleMarkBox.Items.AddRange(new object[] { "BMW", "Ford", "Toyota", "Chevrolet", "Honda", "Hyundai", "Volkswagen", "Audi", "Bentley", "Dodge", "Nissan", "Daimler AG", "Ferrari", "Fisker", "Jeep", "Mazda", "Subaru", "Acura", "American Motors", "Bugatti", "Cadillac", "Chrysler", "DeLorean", "Geely" });
            vehicleMarkBox.Location = new Point(34, 341);
            vehicleMarkBox.Name = "vehicleMarkBox";
            vehicleMarkBox.Size = new Size(273, 23);
            vehicleMarkBox.TabIndex = 4;
            vehicleMarkBox.Text = "All brand";
            vehicleMarkBox.SelectedIndexChanged += vehicleMarkBox_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 317);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 5;
            label2.Text = "Car brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 365);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 7;
            label3.Text = "Model";
            // 
            // vehicleModelBox
            // 
            vehicleModelBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            vehicleModelBox.ForeColor = Color.Gray;
            vehicleModelBox.FormattingEnabled = true;
            vehicleModelBox.Location = new Point(34, 389);
            vehicleModelBox.Name = "vehicleModelBox";
            vehicleModelBox.Size = new Size(273, 23);
            vehicleModelBox.TabIndex = 6;
            vehicleModelBox.Text = "All models";
            vehicleModelBox.SelectedIndexChanged += vehicleModelBox_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 416);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 475);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 12;
            label5.Text = "Odometer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 530);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 18;
            label6.Text = "Engine capacity";
            // 
            // txtBoxCarDecription
            // 
            txtBoxCarDecription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxCarDecription.ForeColor = Color.Gray;
            txtBoxCarDecription.Location = new Point(392, 355);
            txtBoxCarDecription.Multiline = true;
            txtBoxCarDecription.Name = "txtBoxCarDecription";
            txtBoxCarDecription.Size = new Size(775, 183);
            txtBoxCarDecription.TabIndex = 21;
            txtBoxCarDecription.Text = "Car description";
            txtBoxCarDecription.Click += txtBoxCarDecription_Click;
            txtBoxCarDecription.TextChanged += txtCarDescription_TextChanged_1;
            // 
            // btnAccept
            // 
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAccept.ForeColor = Color.Green;
            btnAccept.Location = new Point(392, 609);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(107, 47);
            btnAccept.TabIndex = 22;
            btnAccept.Text = "Confirm";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(1056, 619);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 47);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pctrCar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(602, 13);
            label7.Name = "label7";
            label7.Size = new Size(438, 65);
            label7.TabIndex = 33;
            label7.Text = "Added car for sale";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(602, 676);
            label8.Name = "label8";
            label8.Size = new Size(335, 17);
            label8.TabIndex = 34;
            label8.Text = "(с)This site was developed by a team of young tigers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.White;
            label9.Location = new Point(77, 25);
            label9.Name = "label9";
            label9.Size = new Size(196, 50);
            label9.TabIndex = 35;
            label9.Text = "Car Filtres";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(34, 589);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 36;
            label10.Text = "Fuel type";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxPrice.ForeColor = Color.Gray;
            txtBoxPrice.Location = new Point(34, 440);
            txtBoxPrice.Multiline = true;
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(273, 32);
            txtBoxPrice.TabIndex = 38;
            txtBoxPrice.Text = "in uah";
            txtBoxPrice.TextChanged += txtBoxPrice_TextChanged_1;
            // 
            // txtBoxOdometer
            // 
            txtBoxOdometer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxOdometer.ForeColor = Color.Gray;
            txtBoxOdometer.Location = new Point(34, 495);
            txtBoxOdometer.Multiline = true;
            txtBoxOdometer.Name = "txtBoxOdometer";
            txtBoxOdometer.Size = new Size(273, 32);
            txtBoxOdometer.TabIndex = 39;
            txtBoxOdometer.Text = "in km";
            txtBoxOdometer.TextChanged += txtBoxOdometer_TextChanged;
            // 
            // txtBoxCapacity
            // 
            txtBoxCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxCapacity.ForeColor = Color.Gray;
            txtBoxCapacity.Location = new Point(34, 554);
            txtBoxCapacity.Multiline = true;
            txtBoxCapacity.Name = "txtBoxCapacity";
            txtBoxCapacity.Size = new Size(273, 32);
            txtBoxCapacity.TabIndex = 40;
            txtBoxCapacity.Text = "in litres";
            txtBoxCapacity.TextChanged += txtBoxCapacity_TextChanged;
            // 
            // txtBoxFuelType
            // 
            txtBoxFuelType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxFuelType.ForeColor = Color.Gray;
            txtBoxFuelType.Location = new Point(34, 619);
            txtBoxFuelType.Multiline = true;
            txtBoxFuelType.Name = "txtBoxFuelType";
            txtBoxFuelType.Size = new Size(273, 32);
            txtBoxFuelType.TabIndex = 41;
            txtBoxFuelType.Text = "input type";
            txtBoxFuelType.TextChanged += txtBoxFuelType_TextChanged;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(txtBoxFuelType);
            Controls.Add(txtBoxCapacity);
            Controls.Add(txtBoxOdometer);
            Controls.Add(txtBoxPrice);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtBoxCarDecription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(vehicleModelBox);
            Controls.Add(label2);
            Controls.Add(vehicleMarkBox);
            Controls.Add(label1);
            Controls.Add(vehicleTipeBox);
            Controls.Add(txtBoxPhotoDecription);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCarForm";
            Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBoxPhotoDecription;
        private ComboBox vehicleTipeBox;
        private Label label1;
        private ComboBox vehicleMarkBox;
        private Label label2;
        private Label label3;
        private ComboBox vehicleModelBox;
        private Label label4;
        private Label label5;
        private TextBox txtOdometerMin;
        private TextBox txtOdometerMax;
        private TextBox textBox6;
        private TextBox txt;
        private Label label6;
        private TextBox txtBoxCarDecription;
        private Button btnAccept;
        private Button btnCancel;
        private TextBox txtOdo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtBoxPrice;
        private TextBox txtBoxOdometer;
        private TextBox txtBoxCapacity;
        private TextBox txtBoxFuelType;
    }
}