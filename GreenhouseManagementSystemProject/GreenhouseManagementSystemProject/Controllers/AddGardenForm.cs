using GreenhouseManagmentSystem.Controllers;
using System;
using System.Windows.Forms;


namespace GreenhouseManagmentSystem
{
    public partial class AddGardenPage : Form
    {
        public AddGardenPage()
        {
            InitializeComponent();
        }

        private void BtnAddGarden_Click(object sender, EventArgs e)
        {
            var gareden = new GardenCharacteristicsPage(new Models.GreenHouse());
            gareden.Show();
            Close();
        }

        private void ShowGardensBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var greenHouses = DataBase.Sql.GetGreenHouses();
            var gardens = new GardensPage(greenHouses);
            gardens.Show();
            Close();
        }
    }
}
