using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AutoriaWinForm.Data.Entities;
using Autoria.Helpers;
using AutoriaWinForm.Data;


namespace AutoriaWinForm.Forms
{


    public partial class AddCarForm : Form
    {

        private CarEntity newCar;
        public AddCarForm()
        {
            InitializeComponent();
            newCar = new CarEntity();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            vehicleTipeBox.Items.Add("Усі види транспорту");
        }

        private void vehicleMarkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicleMarkBox.Items.Add("Усі марки авто");
        }

        private void vehicleModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicleModelBox.Items.Add("Усі моделі авто");
        }

        private void vehicleTipeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicleType = vehicleTipeBox.SelectedItem.ToString();
            newCar.VehicleType = selectedVehicleType;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void vehicleMarkBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedVehicleMark = vehicleTipeBox.SelectedItem.ToString();
            newCar.Brand = selectedVehicleMark;
        }

        private void vehicleModelBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedVehicleModel = vehicleTipeBox.SelectedItem.ToString();
            newCar.Model = selectedVehicleModel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string selectedVehiclePrice = vehicleTipeBox.SelectedItem.ToString();
            newCar.Price = selectedVehiclePrice;
        }

        private void txtOdo_TextChanged(object sender, EventArgs e)
        {
            string selectedVehicleOdometer = vehicleTipeBox.SelectedItem.ToString();
            newCar.Odometer = selectedVehicleOdometer;
        }

        private void txtCap_TextChanged(object sender, EventArgs e)
        {
            string selectedVehicleEngineCapacity = vehicleTipeBox.SelectedItem.ToString();
            newCar.EngineCapacity = selectedVehicleEngineCapacity;
        }

        private void txtFuelType_TextChanged(object sender, EventArgs e)
        {
            string selectedVehicleFuelType = vehicleTipeBox.SelectedItem.ToString();
            newCar.FuelType = selectedVehicleFuelType;
        }

        private void txtPhotoDescription_TextChanged_1(object sender, EventArgs e)
        {

            string inputData = txtBoxPhotoDecription.Text;
            newCar.PhotoDescription = inputData;
        }

        private void txtCarDescription_TextChanged_1(object sender, EventArgs e)
        {
            string inputData = txtBoxCarDecription.Text;
            newCar.CarDescription = inputData;

        }

        private void pctrCar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string imageName = Path.GetFileName(imagePath);
                    string folderName = "car_images";
                    string savedImageName = ImageWorker.ImageSave(imagePath, folderName, imageName);
                    if (savedImageName != null)
                    {
                        MessageBox.Show("Зображення успішно завантажено!");
                    }
                    else
                    {
                        MessageBox.Show("Помилка при завантаженні зображення.");

                    }
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(newCar.VehicleType) || string.IsNullOrEmpty(newCar.Brand) || string.IsNullOrEmpty(newCar.Model))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля (тип, марку та модель автомобіля).");
                return;
            }

            try
            {

                using (var dbContext = new AutoriaContext())
                {
                    dbContext.Cars.Add(newCar);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Новий автомобіль успішно додано!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних про автомобіль: {ex.Message}");
            }
        }

        private void txtBoxPhotoDecription_Click(object sender, EventArgs e)
        {
            txtBoxPhotoDecription.Text = string.Empty;
        }

        private void txtBoxCarDecription_Click(object sender, EventArgs e)
        {
            txtBoxCarDecription.Text = string.Empty;
        }
    }
}
