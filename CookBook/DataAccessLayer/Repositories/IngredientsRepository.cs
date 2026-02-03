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
using DataAccessLayer.Contracts;

namespace DataAccessLayer.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        public async Task AddIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @"insert into Ingredients 
                (Name, Weight, KcalPer100g, PricePer100g, Type) 
                values (@Name, @Weight, @KcalPer100g, @PricePer100g, @Type) ";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch(SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627) // Unique constraint error number
                {
                    errorMessage = "An ingredient with this name already exists.";
                }
                else
                {
                    errorMessage = "An error happened in the database";
                }
            }
            catch (Exception ex) 
            {
                string errorMessage = "An error happened while adding ingredient"; //Stores the message from the exception
                //TODO: Display error message
            }
        }
        public async Task<List<Ingredient>> GetIngredients(string? name = "")
        {
            string query = "select * from Ingredients";
            if (!string.IsNullOrEmpty(name))
                query += $" where Name like '{name}%'";

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                return (await connection.QueryAsync<Ingredient>(query)).ToList();
            }
        }

        public async Task DeleteIngredient(Ingredient ingredient)
        {
            string query = @$"delete from Ingredients where Id = {ingredient.Id}";

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                await connection.ExecuteAsync(query);
            }
        }
        public async Task EditIngredient(Ingredient ingredient)
        {
            string query = @"update Ingredients
                              set
                              Name = @Name,
                              Weight = @Weight,
                              KcalPer100g = @KcalPer100g,
                              PricePer100g = @PricePer100g,
                              Type = @Type
                              where Id = @Id";

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                await connection.ExecuteAsync(query, ingredient);
            }
        }

    }
}
