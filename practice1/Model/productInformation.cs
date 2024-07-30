using System.ComponentModel.DataAnnotations;

namespace practice1.Model
{
    public class productInformation
    {

        [Key]
        public int patientId { get; set; }
        public  string patientName { get; set; }
        public int patientAge { get; set; }
        public  string ModelName { get; set; }
        public  string ProductDescription { get; set; }
        public string ProductCategory { get; set; }

    }
}
