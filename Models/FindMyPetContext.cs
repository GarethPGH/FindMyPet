﻿using System;
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

        public class NewFindMyPetContext : CreateDatabaseIfNotExists<FindMyPetContext>
        {
            protected override void Seed(FindMyPetContext context)
            {
                base.Seed(context);
            }
        }

        public DbSet<OwnerProfile> Profiles { get; set; }

            public DbSet<PetRecord> Pets { get; set; }
        
    }


}

