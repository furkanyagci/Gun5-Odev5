using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN" && gamer.LastName == "DEMİROĞ" && gamer.IdentityNumber == 12345678901)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
