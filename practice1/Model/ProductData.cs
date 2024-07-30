using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice1.Model
{
    public class ProductData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public required string  ProductName { get; set; }

        public required string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
    }


    }

