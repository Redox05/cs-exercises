﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using DomainModel.Models;
using DomainModel;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        readonly IIngredientsRepository _ingredientsRepository;
        public IngredientsForm(IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
        }
        private async void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);

            AddToFridgeBtn.Enabled = false;

            await _ingredientsRepository.AddIngredient(ingredient);

            ClearAllFields();
            RefreshGridData();

            AddToFridgeBtn.Enabled = true; 

        }
        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            TypeTxt.Text = string.Empty;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = 0;
            PricePer100gNum.Value = 0;
            SearchTxt.Text = string.Empty;

        }
        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshGridData();
            CustomizeGridAppearance();
        }
        private async void RefreshGridData()
        {
            IngredientsGrid.DataSource = await _ingredientsRepository.GetIngredients(SearchTxt.Text);
        }
        private void CustomizeGridAppearance()
        {
            IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];

            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price (100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal (100g)" };

            //If you run the app with just the code above, modifications will not be shown.
            //You need to implement the following code to see the changes.

            IngredientsGrid.Columns.Clear();

            IngredientsGrid.Columns.AddRange(columns);
        }
        private void ClearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        private async void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            int lengthBeforePause = SearchTxt.Text.Length;

            await Task.Delay(500);

            int lengthAfterPause = SearchTxt.Text.Length;

            if(lengthBeforePause == lengthAfterPause)
            {
                RefreshGridData();
            }
        }
        private bool IsValid()
        {
            bool isValid = true;
            string message = "";
            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            else
            {
                List<Ingredient> ingredients = (List<Ingredient>) IngredientsGrid.DataSource;

                foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient.Name.ToLower() == NameTxt.Text.ToLower())
                    {
                        MessageBox.Show("That ingredient already exists!", "Form is not valid!");
                        return false;
                    }
                }

            }
            if (string.IsNullOrEmpty(TypeTxt.Text))
            {
                isValid = false;
                message += "Please enter type.\n\n";
            }
            if (WeightNum.Value <=0)
            {
                isValid = false;
                message += "Weight must be greater than 0.\n\n";
            }
            if (KcalPer100gNum.Value < 0)
            {
                isValid = false;
                message += "Please enter a valid number of Kcal.\n\n";
            }
            if (PricePer100gNum.Value <= 0)
            {
                isValid = false;
                message += "Price must be greater than 0.\n\n";
            }
            if (!isValid)
            {
                MessageBox.Show(message, "Not a valid form!");
            }
            return isValid;
        }
    }
}

