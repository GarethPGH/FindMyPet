using System.Collections.Generic;
using FindMyPet.Controllers;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyPet.Models
{
    public partial class PetRecord
    {
        [Key]
        public int PetID { get; set; }

        private string OwnerName;

        public string GetOwnerName(){
            return OwnerName;
        }
        public void SetOwnerName(string fname, string lname){
            OwnerName = fname + " " + lname;
             }


        [Required]
        public string PetName { get; set; }

        //Species and Breed will eventually be taken from a table of species and breeds, for now species is dog and breeds is user defined
        [Required]
        public string Species {
            get { return Species; }
            set { Species = "Dog"; }
        }
            
        public string Breed { get; set; }

        [Required]
        public string Description { get; set; }

        public string ImageURL { get; set; }

        public string SpecialNeeds { get; set; }

        public string LocationLost { get; set; }

        //This should automatically be a foreign key that points to the OwnerID in OwnerProfile
        public int OwnerID { get; set; }
        public OwnerProfile Owner { get; set; }

    }

}