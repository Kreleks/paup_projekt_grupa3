using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vjezba02.Controllers
{
    public class GodisteController : Controller
    {
        public static bool ProvjeriGodiste(DateTime Godiste)
        {
            DateTime dr = Godiste;
            DateTime dr_now = DateTime.Now;

            DateTime dr_18 = dr.AddYears(18);
            int godina = dr_now.Year - dr.Year;
            if (godina > 18)
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