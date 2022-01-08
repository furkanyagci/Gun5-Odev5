using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5
{
    interface IUserValidation//kullanıcıyı doğrulama
    {
        bool Validate(Gamer gamer);
    }
}
