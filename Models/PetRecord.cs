using System.Collections.Generic;
using FindMyPet.Controllers;

namespace FindMyPet.Models
{
    public class PetRecord
    {
        private ICollection<string> PetName;

        public ICollection<string> GetName()
        {
            return PetName;
        }

        public void SetName(ICollection<string> value)
        {
            PetName = value;
        }
    }

}