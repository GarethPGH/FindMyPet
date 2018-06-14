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
        [Key,ForeignKey("Owner")]
        private int OwnerID { get; set; }

        [Required]
        [StringLength(50)]
        private string UserName { get; set; }

        [Required]
        private string PassHash { get; set; }

        [StringLength(50)]
        private string FName { get; set; }

        [StringLength(50)]
        private string LName { get; set; }

        [StringLength(15)]
        private string Zipcode { get; set; }

        [StringLength(22)]
        private string PhoneNum { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")]
        private object Email { get; set; }

        //I have a feeling that the FK should be here
        public virtual PetRecord Pets { get; set; }

    }
}
