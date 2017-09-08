using System.ComponentModel.DataAnnotations;

namespace ProductStore.Repository.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number must be greater than 0")]
        public int Number { get; set; }

        //todo: Annotations messages should be part of resource file
        [Required(ErrorMessage = "Name is required")]
        public string Title { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
