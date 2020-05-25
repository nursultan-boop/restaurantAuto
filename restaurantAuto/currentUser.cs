using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantAuto
{
    public static class currentUser
    {
        public static string userLogin { get; set; }
        public static int index { get; set; }
        public static int adminUserIndex { get; set; } = 2;
    }
}
