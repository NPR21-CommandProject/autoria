using Autoria.Helpers;
using AutoriaWinForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoriaWinForm
{
    public partial class ItemForm : Form
    {
        //id Авто, яке ми хочемо переглянуть
        public int CarId { get; set; }// = 5;
        private readonly AutoriaContext autoriaContext = new AutoriaContext();
        string[] images;
        int current = 0;
        public ItemForm()
        {
            InitializeComponent();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRightImage_Click(object sender, EventArgs e)
        {
            current++;
            pbCarImage.Image = Image.FromStream(ImageWorker.GetFileStream(images[current]));
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            var car = autoriaContext.Cars
                .Include(x => x.CarImages)
                .SingleOrDefault(x => x.Id == CarId);
            lbPrice.Text = car.Price.ToString() + " грн.";
            lbCarName.Text = car.Brand + " " + car.Model;
            lbOdometer.Text = car.Odometer;
            string dir = Path.Combine(Directory.GetCurrentDirectory(), "images", car.Model);
            //показуємо 1 фото із усіх
            var list = car.CarImages.OrderBy(x => x.Priority).ToList();
            int n = list.Count;
            images = new string[n];
            for (int i = 0; i < n; i++)
            {
                images[i] = Path.Combine(dir, "600_" + list[i].Name); ;
            }

            pbCarImage.Image = Image.FromStream(ImageWorker.GetFileStream(images[0]));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRightImage_Click(object sender, EventArgs e)
        {
            current++;
            pbCarImage.Image = Image.FromStream(ImageWorker.GetFileStream(images[current]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current--;
            pbCarImage.Image = Image.FromStream(ImageWorker.GetFileStream(images[current]));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

            var car = autoriaContext.Cars
                .Include(x=>x.AddedByUser)
                .FirstOrDefault(c => c.Id == CarId);
            if (car != null)
            {
                var user = car.AddedByUser; // autoriaContext.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    string phoneNumber = user.Phone;
                    string userName = user.FirstName;
                    string userSurname = user.LastName;
                    label5.Text = phoneNumber;
                    lbUserName.Text = userName;
                    lbUserSurnme.Text = userSurname;
                }
                else
                {
                    label5.Text = "Користувача не знайдено";
                }
            }
            else
            {
                label5.Text = "Автомобіль не знайдено";
            }
        }
    }
}
