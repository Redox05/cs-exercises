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

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);

            _ingredientsRepository.AddIngredient(ingredient);
            ClearAllFields();
            RefreshGridData();

        }

        private void ClearAllFields()
        {
            NameTxt.Text = default;
            TypeTxt.Text = default;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = default;
            PricePer100gNum.Value = default;

        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshGridData();
            CustomizeGridAppearance();
        }

        private void RefreshGridData()
        {
            IngredientsGrid.DataSource = _ingredientsRepository.GetIngredients();
        }
        private void CustomizeGridAppearance()
        {
            IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];

            columns[0] = new DataGridViewTextBoxColumn() {DataPropertyName = "Id", Visible=false};
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText ="Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price (100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal (100g)" };

            //If you run the app with just the code above, modifications will not be shown.
            //You need to implement the following code to see the changes.

            IngredientsGrid.Columns.Clear();

            IngredientsGrid.Columns.AddRange(columns);
        }
    }
}

