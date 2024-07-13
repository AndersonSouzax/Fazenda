using MyFazendaFrame.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFazendaFrame.Data.EFContext
{
    public class MainContext : DbContext
    {
        public MainContext() : base("FazendaConnection") 
        {
            Database.SetInitializer<MainContext>(null);
        }

        public DbSet<Semente> Sementes { get; set; } = null;
    }
}
