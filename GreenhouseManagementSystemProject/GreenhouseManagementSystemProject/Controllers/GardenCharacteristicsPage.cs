using GreenhouseManagmentSystem.Enums;
using GreenhouseManagmentSystem.Models;
using System;
using System.Windows.Forms;

namespace GreenhouseManagmentSystem.Controllers
{
    public partial class GardenCharacteristicsPage : Form
    {
        private GreenHouse _garden;

        public GardenCharacteristicsPage(GreenHouse garden)
        {
            InitializeComponent();
            _garden = garden;
            ShowGarden();
        }

        private void ShowGarden()
        {
            TypeOfGardensComboBox.SelectedIndex = (int)_garden.Type;
            TxtNumberOfPlants.Text = _garden.NumberOfPlants.ToString();
            TxtSizeOfArea.Text = _garden.Size.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            _garden.Type = (TypeOfGreenHouse)TypeOfGardensComboBox.SelectedIndex;
            _garden.NumberOfPlants = int.Parse(TxtNumberOfPlants.Text);
            _garden.Size = double.Parse(TxtSizeOfArea.Text);

            if (DataBase.Sql.AddGarden(_garden))
            {
                var greenHouses = DataBase.Sql.GetGreenHouses();
                var gardens = new GardensPage(greenHouses);
                Close();
                gardens.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
