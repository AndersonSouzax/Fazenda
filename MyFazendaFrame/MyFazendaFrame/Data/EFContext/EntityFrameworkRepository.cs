using MyFazendaFrame.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFazendaFrame.Data.EFContext
{
    public class EntityFrameworkRepository
    {
        public Semente GetSementeByFrutaId(int id)
        {
            using (var context = new MainContext())
            {
                return context.Sementes.FirstOrDefault(s => s.FrutaId == id);
            }
        }
    }
}
