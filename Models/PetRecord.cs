using System.Collections.Generic;
using FindMyPet.Controllers;

namespace FindMyPet.Models
{
    public class PetRecord
    {
        [Key]
        private int PetID { get; set; }

        [Key, ForeignKey("Owner"), Column(Order = 0)]
        private int OwnerID { get; set; }

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