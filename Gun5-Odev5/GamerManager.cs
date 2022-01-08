using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5
{
    class GamerManager : IGamerService
    {
        //MicroService 

        IUserValidation _userValidation;
        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
