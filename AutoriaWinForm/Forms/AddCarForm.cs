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
using System.IO;


namespace AutoriaWinForm.Forms
{


    public partial class AddCarForm : Form
    {

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
            // Retrieve the client coordinates of the mouse pointer..
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
            cbVehicleType.Items.Add("Усі види транспорту");
        }

        private void vehicleMarkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBrand.Items.Add("Усі марки авто");
        }

        private void vehicleModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Add("Усі моделі авто");
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                        lvImages.LargeImageList.Images.Add(key, 
                            Image.FromStream(ImageWorker.GetFileStream(imagePath)));
                        lvImages.Items.Add(item);
                    }
                    
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var entity = new CarEntity();

            entity.Brand = cbBrand.Text;
            entity.Model = cbModel.Text;
            entity.VehicleType = cbVehicleType.Text;
            entity.Price = txtPrice.Text;
            entity.Odometer = txtOdometer.Text;
            entity.EngineCapacity = txtEngineCapacity.Text;
            entity.FuelType = txtFuelType.Text;
            entity.CarDescription = txtCarDecription.Text;
            entity.DateCreated = DateTime.Now;

            try
            {
                using (var dbContext = new AutoriaContext())
                {
                    dbContext.Cars.Add(entity);
                    dbContext.SaveChanges();

                    short priotiry = 1;
                    foreach(ListViewItem item in lvImages.Items)
                    {
                        string path = (string)item.Tag;
                        var imageName = ImageWorker.ImageSaveFile(path, entity.Model);
                        var entityImage = new CarImageEntity()
                        {
                            CarId = entity.Id,
                            DateCreated = DateTime.Now,
                            Name = imageName,
                            Priority = priotiry
                        };
                        dbContext.CarImages.Add(entityImage);
                        dbContext.SaveChanges();
                        priotiry++;
                    }
                }
                MessageBox.Show("Новий автомобіль успішно додано!");
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних про автомобіль: {ex.Message}");
            }
        }

        
    }
}
