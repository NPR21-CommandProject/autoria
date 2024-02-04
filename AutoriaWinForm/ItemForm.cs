using AutoriaWinForm.Data;
using System;
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
        public int CarId { get; set; } = 5;
        private readonly AutoriaContext autoriaContext = new AutoriaContext();
        public ItemForm()
        {
            InitializeComponent();

            var car = autoriaContext.Cars.SingleOrDefault(x => x.Id == CarId);
            lbPrice.Text=car.Price.ToString()+" грн.";
            lbCarName.Text=car.Brand+" "+car.Model;
            lbOdometer.Text = car.Odometer;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
