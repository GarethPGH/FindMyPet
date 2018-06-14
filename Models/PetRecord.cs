using System.Collections.Generic;
using FindMyPet.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyPet.Models
{
    public class PetRecord
    {
        [Key]
        private int PetID { get; set; }

        [ForeignKey("OwnerId")]
        //I have a feeling that the FK on PetRecord should not match OwnerProfile
        private int Owner { get; set; }

        private string OwnerName { get; set; }

        [Required]
        private string PetName { get; set; }
        [Required]
        private string Species { get; set; }

        private string Breed { get; set; }

        [Required]
        private string Description { get; set; }

        private string ImageURL { get; set; }

        private string SpecialNeeds { get; set; }

        private string LocationLost { get; set; }

    }

}