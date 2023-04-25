using GreenhouseManagmentSystem.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreenhouseManagmentSystem
{
    public partial class GardensPage : Form
    {
        private List<GreenHouse> _gardens;
        private BindingSource bindingSource = new BindingSource();
        public GardensPage(List<GreenHouse> gardens)
        {
            InitializeComponent();
            _gardens = gardens;
            ShowGardens();
        }

        private void ShowGardens()
        {
            if (_gardens != null) 
            {
                bindingSource.DataSource = _gardens;
                GardenDataGrid.DataSource = bindingSource;
                GardenDataGrid.Refresh();
            }
        }

        private void BtnEditGarden_Click(object sender, System.EventArgs e)
        {
            Close();
            var selectedGarden = _gardens[GardenDataGrid.CurrentCell.RowIndex];
            var gardenPage = new GardenCharacteristicsPage(selectedGarden);
            gardenPage.Show();
        }

        private void BtnDeleteGarden_Click(object sender, System.EventArgs e)
        {
            var selectedGarden = _gardens[GardenDataGrid.CurrentCell.RowIndex];
            DataBase.Sql.DeleteGarden(selectedGarden.Id);
            var dGarden = _gardens.FirstOrDefault(g => g.Id == selectedGarden.Id);
            GardenDataGrid.DataSource = null;
            _gardens.Remove(dGarden);
            ShowGardens();
        }

        private void BtnSearchGarden_Click(object sender, System.EventArgs e)
        {
            string phrase = SearchBox.Text;
            
            if (!string.IsNullOrEmpty(phrase))
            {
                var filteredGardens = _gardens
                .FindAll(g => phrase.Contains(g.Id.ToString()) ||
                phrase.Contains(g.Type.ToString()) ||
                phrase.Contains(g.Size.ToString()) ||
                phrase.Contains(g.NumberOfPlants.ToString()));
                bindingSource.DataSource = filteredGardens;
                GardenDataGrid.DataSource = bindingSource;
                GardenDataGrid.Refresh();
            }
            else
            {
                ShowGardens();
            }
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Close();
            var newGarden = new GardenCharacteristicsPage(new GreenHouse());
            newGarden.Show();
        }
    }
}
