using AutoriaWinForm.Data;
using AutoriaWinForm.Data.Entities;

namespace AutoriaWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserEntity kot=new UserEntity
            {
                FirstName="�����",
                LastName="������",
                Email="kotyk@gmail.com",
                Password="123456",
                DateCreated=DateTime.Now,
                Phone="+380 97 638 87 34"
            };
            AutoriaContext context = new AutoriaContext();
            context.Users.Add(kot);
            context.SaveChanges();
        }
    }
}
