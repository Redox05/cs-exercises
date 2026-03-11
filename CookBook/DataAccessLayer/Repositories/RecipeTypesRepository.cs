using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using Infrastructure;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RecipeTypesRepository : IRecipeTypesRepository
    {
        public event Action<string> OnError;

        private void ErrorOccurred(string errorMessage)
        {
            if (OnError != null)
            {
                OnError.Invoke(errorMessage);
            }
            Logger.LogError(errorMessage);
        }


        public async Task AddRecipeType(RecipeType recipeType)
        {
            try
            {
                string query = @"insert into RecipeTypes 
                (Name) values (@Name) ";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeType);
                }
            }
            
            catch (Exception ex)
            {
                string errorMessage = "An error happened while adding recipe type"; //Stores the message from the exception
                //TODO: Display error message
                ErrorOccurred(errorMessage); // Notify subscribers about the error
            }
        }

        public async Task<List<RecipeType>> GetRecipeTypes()
        {
            try
            {
                string query = "select * from RecipeTypes";
                
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while getting recipe types.";

                ErrorOccurred(errorMessage);
                return new List<RecipeType>();
            }
        }
    }
}
