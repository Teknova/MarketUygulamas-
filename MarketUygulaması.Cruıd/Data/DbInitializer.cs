using MarketUygulaması.Cruıd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketUygulaması.Cruıd.Data
{
    public class DbInitializer
    {

        public static void Initializer(CrudContext context)
        {
            context.Database.EnsureCreated();
            if (context.askers.Any())
            {
                return;
            }
            var askerim = new Asker[] {
                new Asker{Name="Ali",Surname="Orta",Yas=20,Aktif=true},
                 new Asker{Name="Veli",Surname="Sel",Yas=22,Aktif=true}
            };
            foreach (var asker in askerim)
            {
                context.askers.Add(asker);
            }
            context.SaveChanges();

        }

        internal static void initialize()
        {
            throw new NotImplementedException();
        }
    }
}
