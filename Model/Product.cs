using System.ComponentModel.DataAnnotations;

namespace GEfrontEnd.Model
{
    public class Product
    {

        [Required(ErrorMessage = "The Id field is required.")]
        public int Id { get; set; }

       [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Version field is required.")]
        

        public string Version { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string Description { get; set; }

        // Parameterless constructor (needed for deserialization and frameworks)
        //public Product()
        //{
        //}


        //Constructor
        //public Product(int IdCurrent, string nameurrent, string versionurrent, string descriptionurrent)
        //{
        //    Id = IdCurrent;
        //    Name = nameurrent;
        //    Version = versionurrent;
        //    Description = descriptionurrent;

        //}


    }

}





