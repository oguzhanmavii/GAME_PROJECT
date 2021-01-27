using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {

        void Ekle(Gamer gamer);
        void Guncelle(Gamer gamer);

        void Sil(Gamer gamer);

    }
}
