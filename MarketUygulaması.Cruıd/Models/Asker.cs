using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketUygulaması.Cruıd.Models
{
    public class Asker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Yas { get; set; }
        public bool Aktif { get; set; }
    }
}
