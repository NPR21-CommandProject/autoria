using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoriaWinForm.Forms
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
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

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
