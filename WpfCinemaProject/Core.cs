using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCinemaProject
{
    public static class Core
    {
        public static CinemaDBEntities Context = new CinemaDBEntities();

        public static Users CurrentUser = null;
    }
}
