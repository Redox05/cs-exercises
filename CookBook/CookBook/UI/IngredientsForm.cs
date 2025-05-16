using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            Ingredient i1 = new Ingredient { Name = "Banana", Type = "fruit", Weight = 500, KcalPer100g = 110.2m, PricePer100g = 5.2m };
            Ingredient i2 = new Ingredient { Name = "Apple", Type = "fruit", Weight = 100, KcalPer100g = 75.3m, PricePer100g = 6.3m };
            Ingredient i3 = new Ingredient { Name = "T-bone", Type = "protein", Weight = 1000, KcalPer100g = 130.5m, PricePer100g = 10.1m };

            ingredients.Add(i1);
            ingredients.Add(i2);
            ingredients.Add(i3);

            string message = "";

            ingredients.ForEach(i => { message += $@"{i.Name} {i.Type} {i.Weight} {i.KcalPer100g} {i.PricePer100g}"; });

            MessageBox.Show(message);
        }
    }
}

