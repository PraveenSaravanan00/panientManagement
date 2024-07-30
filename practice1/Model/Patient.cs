using System.ComponentModel.DataAnnotations;

namespace practice1.Model
{
    public class Patient
    {


        [Key]

        public int patientId {get;set;}
        public required string patientName { get;set;}
        public int patientAge { get;set;}
        public required string patientGender { get;set;}

    }
}
