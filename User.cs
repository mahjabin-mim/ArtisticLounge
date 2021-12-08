using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gallery
{
    class User
    {
        public static string Email { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }

        public string Gender { set; get; }
        public string Location { set; get; }
        public string Phone { set; get; }
        public Image Picture { set; get; }
    }
}