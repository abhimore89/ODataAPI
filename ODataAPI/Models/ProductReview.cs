using System;
namespace ODataAPI.Models
{
    public class ProductReview
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EmailId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ProductId { get; set; }

    }
}
