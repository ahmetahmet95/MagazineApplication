
using Microsoft.Data.SqlClient;
using ServiceLibrary.Service;
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
using ServiceLibrary;

namespace MagazineApplication.Forms
{
    public partial class UserControlCategory : UserControl
    {
        public UserControlCategory()
        {
            InitializeComponent();
        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            productDataGridView.DataSource = CategoryService.GetAllCategories();
        }
    }
}

