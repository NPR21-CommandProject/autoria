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
using SixLabors.ImageSharp.Formats.Jpeg;
using System.IO;


namespace AutoriaWinForm.Forms
{


    public partial class AddCarForm : Form
    {

        private CarEntity newCar;

        private List<string> ProductImages { get; set; }

        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }

        public AddCarForm()
        {
            InitializeComponent();
            lvImages.LargeImageList = new ImageList();
            lvImages.LargeImageList.ImageSize = new Size(180, 130);
           // lvImages.LargeImageList.
            lvImages.MultiSelect = false;
            lvImages.ListViewItemSorter = new ListViewIndexComparer();
            lvImages.InsertionMark.Color = Color.Green;
            lvImages.AllowDrop = true;

            newCar = new CarEntity();
        }

        #region Drag and Drop Images in ListView
        private void lvImages_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvImages.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvImages_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvImages_DragLeave(object sender, EventArgs e)
        {
            lvImages.InsertionMark.Index = -1;
        }

        private void lvImages_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                lvImages.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = lvImages.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = lvImages.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvImages.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvImages.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            lvImages.InsertionMark.Index = targetIndex;
        }

        private void lvImages_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = lvImages.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (lvImages.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values. 
            lvImages.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            lvImages.Items.Remove(draggedItem);
        }
        #endregion

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

        private void txtCarDescription_TextChanged_1(object sender, EventArgs e)
        {
            string inputData = txtBoxCarDecription.Text;
            newCar.CarDescription = inputData;

        }

        private void pctrCar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(string file in openFileDialog.FileNames)
                    {
                        string imagePath = file;
                        string key = Guid.NewGuid().ToString();
                        ListViewItem item = new ListViewItem();
                        item.Tag = imagePath;
                        item.Text = Path.GetFileName(imagePath);
                        item.ImageKey = key;
                        var image = SixLabors.ImageSharp.Image.Load(imagePath);
                        MemoryStream ms = new MemoryStream();
                        image.Save(ms, new JpegEncoder());
                        lvImages.LargeImageList.Images.Add(key, Image.FromStream(ms));
                        lvImages.Items.Add(item);
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

        private void txtBoxCarDecription_Click(object sender, EventArgs e)
        {
            txtBoxCarDecription.Text = string.Empty;
        }

        private void txtBoxPrice_TextChanged_1(object sender, EventArgs e)
        {
            string inputData = txtBoxPrice.Text;
            newCar.Price = inputData;
        }

        private void txtBoxOdometer_TextChanged(object sender, EventArgs e)
        {
            string inputData = txtBoxOdometer.Text;
            newCar.Odometer = inputData;
        }

        private void txtBoxCapacity_TextChanged(object sender, EventArgs e)
        {
            string inputData = txtBoxCapacity.Text;
            newCar.EngineCapacity = inputData;
        }

        private void txtBoxFuelType_TextChanged(object sender, EventArgs e)
        {
            string inputData = txtBoxFuelType.Text;
            newCar.FuelType = inputData;
        }
    }
}
