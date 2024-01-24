using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tuong
    {
        
        public string ten { get; set; }
        public int damevl { get; set; }
        public int damept { get; set; }

        public tuong(string ten, int damevl, int damept)
        {
            this.ten = ten;
            this.damevl = damevl;
            this.damept = damept;
        }

        public void KyNang1()
        {
            damevl += 2;
        }
    }
}
