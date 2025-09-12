using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DataAccessLayer.Repositories
{
    public class IngredientsRepository
    {
        public void AddIngredient(Ingredient ingredient)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;

            string query = @"insert into Ingredients
                (Name, Weight, KcalPer100g, PricePer100g, Type)
                values(@Name, @Weight, @KcalPer100g, @PricePer100g, @Type)"; 

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, ingredient);
            }
        }

        public List<Ingredient> GetIngredients()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;

            string query = "select * from Ingredients";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Ingredient> ingredients = connection.Query<Ingredient>(query).ToList();
                return ingredients;
            }
        }

    }
}
