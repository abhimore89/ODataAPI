using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string Category { get; set; }
        public List<ProductReview> Reviews { get; set; }
    }

    
}
