using System.Data;
using ModelLibrary;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Service
{
    public static class Service
    {

        private const string connectionString = @"Server=DESKTOP-RVD0IDB\SQLEXPRESS;Database=MagazineDataBase;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True";


        public static List<Category> GetAllCategories()
        {

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                return db.Query<Category>("SELECT * FROM dbo.VwCategory").ToList();
            }
        }
    }
}