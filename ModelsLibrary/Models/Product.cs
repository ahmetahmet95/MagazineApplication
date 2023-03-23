using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
