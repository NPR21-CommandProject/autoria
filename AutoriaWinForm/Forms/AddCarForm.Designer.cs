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
            Cancel = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            comboBox1 = new ComboBox();
            txtPriceMax = new TextBox();
            txtOdoMin = new TextBox();
            txtOdoMax = new TextBox();
            comboBox2 = new ComboBox();
            txtCapMin = new TextBox();
            txtCapMax = new TextBox();
            comboBox3 = new ComboBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPriceMin = new TextBox();
            textBox1 = new TextBox();
            comboBox5 = new ComboBox();
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
            txtBoxPhotoDecription.Size = new Size(775, 174);
            txtBoxPhotoDecription.TabIndex = 1;
            txtBoxPhotoDecription.Text = "Photo decription";
            txtBoxPhotoDecription.TextChanged += textBox1_TextChanged_1;
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
            label5.Location = new Point(34, 464);
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
            label6.Location = new Point(34, 517);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 18;
            label6.Text = "Engine capacity(l.)";
            // 
            // Cancel
            // 
            Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Cancel.ForeColor = Color.Gray;
            Cancel.Location = new Point(392, 314);
            Cancel.Multiline = true;
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(775, 170);
            Cancel.TabIndex = 21;
            Cancel.Text = "Car description";
            // 
            // btnAccept
            // 
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAccept.ForeColor = Color.Green;
            btnAccept.Location = new Point(405, 517);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(107, 47);
            btnAccept.TabIndex = 22;
            btnAccept.Text = "Confirm";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(1056, 517);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 47);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "$", "€", "₴" });
            comboBox1.Location = new Point(266, 440);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(41, 23);
            comboBox1.TabIndex = 24;
            comboBox1.Text = "$";
            // 
            // txtPriceMax
            // 
            txtPriceMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPriceMax.ForeColor = Color.Gray;
            txtPriceMax.Location = new Point(144, 440);
            txtPriceMax.Name = "txtPriceMax";
            txtPriceMax.Size = new Size(104, 23);
            txtPriceMax.TabIndex = 25;
            txtPriceMax.Text = "To";
            // 
            // txtOdoMin
            // 
            txtOdoMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtOdoMin.ForeColor = Color.Gray;
            txtOdoMin.Location = new Point(34, 488);
            txtOdoMin.Name = "txtOdoMin";
            txtOdoMin.Size = new Size(104, 23);
            txtOdoMin.TabIndex = 26;
            txtOdoMin.Text = "From";
            // 
            // txtOdoMax
            // 
            txtOdoMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtOdoMax.ForeColor = Color.Gray;
            txtOdoMax.Location = new Point(144, 488);
            txtOdoMax.Name = "txtOdoMax";
            txtOdoMax.Size = new Size(104, 23);
            txtOdoMax.TabIndex = 27;
            txtOdoMax.Text = "To";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "km", "mi" });
            comboBox2.Location = new Point(266, 488);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(41, 23);
            comboBox2.TabIndex = 28;
            comboBox2.Text = "km";
            // 
            // txtCapMin
            // 
            txtCapMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtCapMin.ForeColor = Color.Gray;
            txtCapMin.Location = new Point(34, 541);
            txtCapMin.Name = "txtCapMin";
            txtCapMin.Size = new Size(104, 23);
            txtCapMin.TabIndex = 29;
            txtCapMin.Text = "From";
            // 
            // txtCapMax
            // 
            txtCapMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtCapMax.ForeColor = Color.Gray;
            txtCapMax.Location = new Point(144, 541);
            txtCapMax.Name = "txtCapMax";
            txtCapMax.Size = new Size(104, 23);
            txtCapMax.TabIndex = 30;
            txtCapMax.Text = "To";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "l", "g" });
            comboBox3.Location = new Point(266, 541);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(41, 23);
            comboBox3.TabIndex = 31;
            comboBox3.Text = "l";
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
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(444, 25);
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
            label8.Location = new Point(444, 665);
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
            label9.Location = new Point(34, 37);
            label9.Name = "label9";
            label9.Size = new Size(196, 50);
            label9.TabIndex = 35;
            label9.Text = "Car Filtres";
            // 
            // txtPriceMin
            // 
            txtPriceMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPriceMin.ForeColor = Color.Gray;
            txtPriceMin.Location = new Point(34, 440);
            txtPriceMin.Name = "txtPriceMin";
            txtPriceMin.Size = new Size(104, 23);
            txtPriceMin.TabIndex = 9;
            txtPriceMin.Text = "From";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(34, 587);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 36;
            textBox1.Text = "Cost";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "$", "€", "₴" });
            comboBox5.Location = new Point(266, 587);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(41, 23);
            comboBox5.TabIndex = 38;
            comboBox5.Text = "$";
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(comboBox5);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox3);
            Controls.Add(txtCapMax);
            Controls.Add(txtCapMin);
            Controls.Add(comboBox2);
            Controls.Add(txtOdoMax);
            Controls.Add(txtOdoMin);
            Controls.Add(txtPriceMax);
            Controls.Add(comboBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(Cancel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPriceMin);
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
        private TextBox Cancel;
        private Button btnAccept;
        private Button btnCancel;
        private ComboBox comboBox1;
        private TextBox txtPriceMax;
        private TextBox txtOdoMin;
        private TextBox txtOdoMax;
        private ComboBox comboBox2;
        private TextBox txtCapMin;
        private TextBox txtCapMax;
        private ComboBox comboBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPriceMin;
        private TextBox textBox1;
        private ComboBox comboBox5;
    }
}