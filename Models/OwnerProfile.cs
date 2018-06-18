using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Configuration;
using System.Runtime.Remoting.Contexts;
using FindMyPet.Controllers;


namespace FindMyPet.Models
{

    public partial class OwnerProfile
    {
        
        [Required]
        [Key]
        public int OwnerID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public string PassHash { get; set; }

        [StringLength(50)]
        public string FName { get; set; }

        [StringLength(50)]
        public string LName { get; set; }

        [StringLength(15)]
        public string Zipcode { get; set; }

        [StringLength(22)]
        public string PhoneNum { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")]
        public object Email { get; set; }

        public ICollection<PetRecord> Pets { get; set; }
    }
}
