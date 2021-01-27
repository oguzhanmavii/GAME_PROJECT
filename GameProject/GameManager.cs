using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GameManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Ekle(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
       
            Console.WriteLine("Kayıdınız Başarı İle Oluşturuldu..");
            }

            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt Başarısız ! ");
            }
        }


        public void Guncelle(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {

                Console.WriteLine("Kayıdınız Başarı İle Guncellendi..");
            }

            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt Güncellenemedi ! ");
            }
        }


        public void Sil(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {

                Console.WriteLine("Kayıdınız Başarı İle Silindi..");
            }

            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt Silinemedi ! ");
            }
        }


    }
}
