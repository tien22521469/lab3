using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SQLiteDataAccess
    {
        public static List<FoodModel> LoadFood()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<FoodModel>("select * from Food", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveFood(FoodModel food)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Food (TenMonAn, IDNCC) values (@TenMonAn, @IDNCC)", food);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void DeleteFood(FoodModel food)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Food WHERE IDMA = @IDMA", connection))
                {
                    command.Parameters.AddWithValue("@IDMA", food.IDMA);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
