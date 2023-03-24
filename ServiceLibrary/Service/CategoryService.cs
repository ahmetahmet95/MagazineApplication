using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using Dapper;
using ModelLibrary;

namespace ServiceLibrary.Service
{
    public static class CategoryService
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
