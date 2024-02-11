using AutoriaWinForm.Data;
using AutoriaWinForm.Data.Entities;

namespace AutoriaWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //UserEntity kot=new UserEntity
            //{
            //    FirstName="Котик",
            //    LastName="Рижикт",
            //    Email="kotyk@gmail.com",
            //    Password="123456",
            //    DateCreated=DateTime.Now,
            //    Phone="+380 97 638 87 34"
            //};
            //AutoriaContext context = new AutoriaContext();
            //List<UserEntity> list = context.Users.ToList();
            //CarEntity car = new CarEntity
            //{
            //    Brand = "BMW",
            //    Model = "5 series",
            //    Price = 12500,
            //    Odometer = "250000",
            //    EngineCapacity = 2,
            //    FuelType = "Gasoline",
            //    DateCreated = DateTime.Now
            //};
            //AutoriaContext context = new AutoriaContext();
            //context.Cars.Add(car);
            //context.SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //..
    }
}
//