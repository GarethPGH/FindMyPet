using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FindMyPet.Models
{
    public class FindMyPetContext : DbContext
    {

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public FindMyPetContext() : base("name=FindMyPetContext")
        {
        }

        public System.Data.Entity.DbSet<FindMyPet.Models.OwnerProfile> Profiles { get; set; }

        //public System.Data.EntityClient.DbSet<FindMyPet.Models.PetRecord> Pets { get; set; }
           
    }
}
