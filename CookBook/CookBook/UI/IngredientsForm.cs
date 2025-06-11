using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
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
            Ingredient ingredient = new Ingredient();

            ingredient.Name = NameTxt.Text;
            ingredient.Type = TypeTxt.Text;
            ingredient.Weight = WeightNum.Value;
            ingredient.KcalPer100g = KcalPer100gNum.Value;
            ingredient.PricePer100g = PricePer100gNum.Value;

            IngredientsDataAccess db = new IngredientsDataAccess();
            db.AddIngredient(ingredient);
            ClearAllFields();

        }

        private void ClearAllFields()
        {
            NameTxt.Text = default;
            TypeTxt.Text = default;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = default;
            PricePer100gNum.Value = default;

        }
    }
}

