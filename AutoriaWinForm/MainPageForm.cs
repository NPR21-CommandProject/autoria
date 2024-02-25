using AutoriaWinForm.Data.Entities;
using AutoriaWinForm.Data;
using AutoriaWinForm.Forms;


namespace AutoriaWinForm
{
    public partial class MainPageForm : Form
    {

        public MainPageForm()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AutoriaContext context = new AutoriaContext();
            List<CarEntity> cars = context.Cars.ToList();
            foreach (var car in cars)
            {
                object[] row = { car.Brand + " " + car.Model + " " + car.Price + "$" };
                dgvShowAllCars.Rows.Add(row);
            }
        }
    }
}
