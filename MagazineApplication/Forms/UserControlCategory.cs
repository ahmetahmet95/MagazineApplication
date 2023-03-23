using Dapper;
using Microsoft.Data.SqlClient;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineApplication.Forms
{
    public partial class UserControlCategory : UserControl
    {
        private const string connectionString = @"Server=DESKTOP-RVD0IDB\SQLEXPRESS;Database=MagazineDataBase;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True";
        public UserControlCategory()
        {
            InitializeComponent();
        }

        public async Task<IEnumerable<Category>> GetCategory()
        {
            var query = "SELECT * FROM dbo.VwCategory";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var companies = await connection.QueryAsync<Category>(query);
                connection.Close();

                return companies.ToList();
            }
        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
                productDataGridView.DataSource = GetCategory();
        }
    }
}

