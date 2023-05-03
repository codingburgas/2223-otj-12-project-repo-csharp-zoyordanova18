using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GreenhouseManagmentSystem.Controllers
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            TxtUsernameR.Clear();
            TxtEmailR.Clear();
            TxtPasswordR.Clear();
            TxtCofirmPassR.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(315, 5);
            Pnl.Location = new Point(5, 5);
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlRegister.Height = PnlMain.Height;
            PnlMain.Location = new Point(5, 5);
            Pnl.Location = new Point(380, 5);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text;
            string password = PasswordBox.Text;

            bool success = DataBase.Sql.Login(username, password);

            if (success)
            {
                var gardens = DataBase.Sql.GetGreenHouses();

                if (gardens != null && gardens.Count > 0)
                {
                    Hide();
                    var gardensPage = new GardensPage(gardens);
                    gardensPage.ShowDialog();
                }
                else
                {
                    Hide();
                    var greenhouse = new AddGardenPage();
                    greenhouse.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Incorrect user name or password!");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var userName = TxtUsernameR.Text;
            var email = TxtEmailR.Text;
            bool correctPassword = TxtPasswordR.Text == TxtCofirmPassR.Text;

            if (correctPassword)
            {
                var password = TxtPasswordR.Text;
                if (DataBase.Sql.AddUser(userName, password, email))
                {
                    ClearData();
                    BtnClose_Click(BtnRegister, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Entered password is incorrect!");
            }
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
