using DataAccessLibrary.Data;
using ModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLibrary.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        } 
    }
}
