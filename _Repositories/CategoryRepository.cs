using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Data;

namespace Supermarket_mvp._Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string connectionString;

        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("INSERT INTO Categories (Name, Description) VALUES (@Name, @Description)", connection))
            { 
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = category.Name;
                command.Parameters.Add("@Description", SqlDbType.VarChar).Value = category.Description;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("DELETE FROM Categories WHERE CategoryId = @id", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("UPDATE Categories SET Name=@name, Description=@desc WHERE CategoryId=@id", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = category.CategoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = category.Description;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Categories ORDER BY CategoryId DESC", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoryModel
                        {
                            CategoryId = (int)reader["CategoryId"],
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(category);
                    }
                }
            }

            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out var id) ? id : 0;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Categories WHERE CategoryId = @id OR Name LIKE @name", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = $"%{value}%";
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoryModel
                        {
                            CategoryId = (int)reader["CategoryId"],
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(category);
                    }
                }
            }

            return categoryList;
        }
    }
}