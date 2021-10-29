using System;
using System.ComponentModel.DataAnnotations;

namespace ODataAPI.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EmailId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Product Product { get; set; }

    }
}
