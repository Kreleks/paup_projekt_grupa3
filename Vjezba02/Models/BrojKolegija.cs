using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezba02.Models
{
    public class BrojKolegija
    {
        public static int ProvjeraBrojKolegija(int BrojKolegija)
        {
            if (BrojKolegija > 8 && BrojKolegija <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

    }
}