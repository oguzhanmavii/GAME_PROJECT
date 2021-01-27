using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if(gamer.Id==7 && gamer.Ad=="Oguzhan" && gamer.Soyad=="Mavi" 
                && gamer.TcNo=="45213357946")
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
