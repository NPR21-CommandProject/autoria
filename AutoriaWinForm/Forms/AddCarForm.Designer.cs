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
            cbVehicleType = new ComboBox();
            label1 = new Label();
            cbBrand = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbModel = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCarDecription = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPrice = new TextBox();
            txtOdometer = new TextBox();
            txtEngineCapacity = new TextBox();
            txtFuelType = new TextBox();
            lvImages = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbVehicleType
            // 
            cbVehicleType.AccessibleName = "";
            cbVehicleType.DisplayMember = "All types of vehicles";
            cbVehicleType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbVehicleType.ForeColor = Color.Gray;
            cbVehicleType.FormattingEnabled = true;
            cbVehicleType.Items.AddRange(new object[] { "Passenger cars", "", "Motorcycles", "", "Trucks", "", "Trailers", "", "Special equipment", "", "Agricultural machinery", "", "Buses", "", "Water transport", "", "Air transport", "", "Motor homes" });
            cbVehicleType.Location = new Point(39, 392);
            cbVehicleType.Margin = new Padding(3, 4, 3, 4);
            cbVehicleType.Name = "cbVehicleType";
            cbVehicleType.Size = new Size(311, 28);
            cbVehicleType.TabIndex = 2;
            cbVehicleType.Text = "All vehicle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 360);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 3;
            label1.Text = "Тип засобу(мотоцикол)";
            // 
            // cbBrand
            // 
            cbBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbBrand.ForeColor = Color.Gray;
            cbBrand.FormattingEnabled = true;
            cbBrand.Items.AddRange(new object[] { "BMW", "Ford", "Toyota", "Chevrolet", "Honda", "Hyundai", "Volkswagen", "Audi", "Bentley", "Dodge", "Nissan", "Daimler AG", "Ferrari", "Fisker", "Jeep", "Mazda", "Subaru", "Acura", "American Motors", "Bugatti", "Cadillac", "Chrysler", "DeLorean", "Geely" });
            cbBrand.Location = new Point(39, 455);
            cbBrand.Margin = new Padding(3, 4, 3, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(311, 28);
            cbBrand.TabIndex = 4;
            cbBrand.Text = "All brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 423);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 5;
            label2.Text = "Бренд(Audi)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 487);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 7;
            label3.Text = "Модель";
            // 
            // cbModel
            // 
            cbModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbModel.ForeColor = Color.Gray;
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(39, 519);
            cbModel.Margin = new Padding(3, 4, 3, 4);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(311, 28);
            cbModel.TabIndex = 6;
            cbModel.Text = "All models";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 555);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 8;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 633);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 12;
            label5.Text = "Пробіг";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 707);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 18;
            label6.Text = "Об'єм двигуна";
            // 
            // txtCarDecription
            // 
            txtCarDecription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtCarDecription.ForeColor = Color.Gray;
            txtCarDecription.Location = new Point(449, 560);
            txtCarDecription.Margin = new Padding(3, 4, 3, 4);
            txtCarDecription.Multiline = true;
            txtCarDecription.Name = "txtCarDecription";
            txtCarDecription.Size = new Size(885, 220);
            txtCarDecription.TabIndex = 21;
            txtCarDecription.Text = "Car description";
            // 
            // btnAccept
            // 
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAccept.ForeColor = Color.Green;
            btnAccept.Location = new Point(448, 812);
            btnAccept.Margin = new Padding(3, 4, 3, 4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(122, 63);
            btnAccept.TabIndex = 22;
            btnAccept.Text = "Confirm";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(1207, 825);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 63);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 156);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 193);
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
            label7.Location = new Point(688, 17);
            label7.Name = "label7";
            label7.Size = new Size(547, 81);
            label7.TabIndex = 33;
            label7.Text = "Added car for sale";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(688, 901);
            label8.Name = "label8";
            label8.Size = new Size(432, 23);
            label8.TabIndex = 34;
            label8.Text = "(с)This site was developed by a team of young tigers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.White;
            label9.Location = new Point(88, 33);
            label9.Name = "label9";
            label9.Size = new Size(246, 62);
            label9.TabIndex = 35;
            label9.Text = "Car Filtres";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(39, 785);
            label10.Name = "label10";
            label10.Size = new Size(125, 28);
            label10.TabIndex = 36;
            label10.Text = "Тип палива";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPrice.ForeColor = Color.Gray;
            txtPrice.Location = new Point(39, 587);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(311, 41);
            txtPrice.TabIndex = 38;
            txtPrice.Text = "in uah";
            // 
            // txtOdometer
            // 
            txtOdometer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtOdometer.ForeColor = Color.Gray;
            txtOdometer.Location = new Point(39, 660);
            txtOdometer.Margin = new Padding(3, 4, 3, 4);
            txtOdometer.Multiline = true;
            txtOdometer.Name = "txtOdometer";
            txtOdometer.Size = new Size(311, 41);
            txtOdometer.TabIndex = 39;
            txtOdometer.Text = "in km";
            // 
            // txtEngineCapacity
            // 
            txtEngineCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEngineCapacity.ForeColor = Color.Gray;
            txtEngineCapacity.Location = new Point(39, 739);
            txtEngineCapacity.Margin = new Padding(3, 4, 3, 4);
            txtEngineCapacity.Multiline = true;
            txtEngineCapacity.Name = "txtEngineCapacity";
            txtEngineCapacity.Size = new Size(311, 41);
            txtEngineCapacity.TabIndex = 40;
            txtEngineCapacity.Text = "in litres";
            // 
            // txtFuelType
            // 
            txtFuelType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtFuelType.ForeColor = Color.Gray;
            txtFuelType.Location = new Point(39, 825);
            txtFuelType.Margin = new Padding(3, 4, 3, 4);
            txtFuelType.Multiline = true;
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(311, 41);
            txtFuelType.TabIndex = 41;
            txtFuelType.Text = "input type";
            // 
            // lvImages
            // 
            lvImages.Location = new Point(448, 156);
            lvImages.Name = "lvImages";
            lvImages.Size = new Size(885, 356);
            lvImages.TabIndex = 42;
            lvImages.UseCompatibleStateImageBehavior = false;
            lvImages.ItemDrag += lvImages_ItemDrag;
            lvImages.DragDrop += lvImages_DragDrop;
            lvImages.DragEnter += lvImages_DragEnter;
            lvImages.DragOver += lvImages_DragOver;
            lvImages.DragLeave += lvImages_DragLeave;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1463, 960);
            Controls.Add(lvImages);
            Controls.Add(txtFuelType);
            Controls.Add(txtEngineCapacity);
            Controls.Add(txtOdometer);
            Controls.Add(txtPrice);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtCarDecription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbModel);
            Controls.Add(label2);
            Controls.Add(cbBrand);
            Controls.Add(label1);
            Controls.Add(cbVehicleType);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cbVehicleType;
        private Label label1;
        private ComboBox cbBrand;
        private Label label2;
        private Label label3;
        private ComboBox cbModel;
        private Label label4;
        private Label label5;
        private TextBox txtOdometerMin;
        private TextBox txtOdometerMax;
        private TextBox textBox6;
        private TextBox txt;
        private Label label6;
        private TextBox txtCarDecription;
        private Button btnAccept;
        private Button btnCancel;
        private TextBox txtOdo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPrice;
        private TextBox txtOdometer;
        private TextBox txtEngineCapacity;
        private TextBox txtFuelType;
        private ListView lvImages;
    }
}