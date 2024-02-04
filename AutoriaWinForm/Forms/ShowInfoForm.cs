using AutoriaWinForm.Data;
using AutoriaWinForm.Data.Entities;
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
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm()
        {
            InitializeComponent();

            AutoriaContext _context = new AutoriaContext();
            List<UserEntity> users = _context.Users.ToList();
            foreach ( var user in users )
            {
                object[] row = { user.LastName + " " + user.FirstName };
                dgvShowAllUsers.Rows.Add(row);
            }

            AutoriaContext context = new AutoriaContext();
            List<CarEntity> cars = context.Cars.ToList();
            foreach (var car in cars)
            {
                object[] row = { car.Brand + " " + car.Model + " " + car.Price + "$"};
                dgvShowAllCars.Rows.Add(row);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShowAllInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dvgShowAllCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShowAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
