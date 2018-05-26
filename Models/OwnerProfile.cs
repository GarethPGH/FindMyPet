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
    
    //public class ownerProfileContext : Context
    //{
    //    public DbSet<Owners> ownerProfiles { get; set; }
    //}
    //[Table("ownerProfile")]
    public partial class OwnerProfile
    {
        [Required]
        private int ownerID { get; set; }

        [Required]
        [StringLength(50)]
        private string UserName;

        [Required]
        private string PassHash;

        [StringLength(50)]
        private string FName;

        [StringLength(50)]
        private string LName;

        [StringLength(15)]
        private string Zipcode;

        [StringLength(22)]
        private string PhoneNum;

        [Required()]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")]
        private object Email;


        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<PetRecord> PetRecords;
        public void SetUserName(string val)
        { 
           
            UserName = val;
        }
        public string GetUserName(string Name)
        {
            this.UserName = Name;
            return UserName;
        }
        public void SetPass (string val)
        {
            PassHash = val;
        }
        public void SetEmail (string val)
        {
            Email = val;
        }
        public string GetUserName()
        {
            return UserName;
        }
        public string GetPass()
        {
            return PassHash;
        }
        public object GetEmail()
        {
            return Email;
        }
        //public void SetRequiredProfileFields(object Email, string UserName, string PassHash)
        //{
        //    UserName = this.UserName;
        //    PassHash = this.PassHash;
        //    Email = this.Email;
        //}

        public void SetFName(string val)
        {
            FName = val;
        }
        public void SetLName(string val)
        {
            LName = val;
        }
        public void SetZip (string val)
        {
            Zipcode = val;
        }
        public void SetPhoneNum(string val)
        {
            PhoneNum = val;
        }
        public string GetFName()
        {
            return FName;
        }
        public string GetLName()
        {
            return LName;
        }
        public string GetZip()
        {
            return Zipcode;
        }
        public string GetPhoneNum()
        {
            return PhoneNum;
        }
        //public void SetUserDetails (string FName, string LName, string Zipcode, string PhoneNum)
        //{
        //    FName = this.FName;
        //    LName = this.LName;
        //    Zipcode = this.Zipcode;
        //    PhoneNum = this.PhoneNum;
        //}
    }
}
