using MyFazendaFrame.Data;
using MyFazendaFrame.Data.EFContext;
using MyFazendaFrame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFazendaFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EntityFrameworkRepository EF_repository = new EntityFrameworkRepository();

            //Semente s = EF_repository.GetSementeByFrutaId(1);

            DapperRepository dapper_repo = new DapperRepository();

            Semente semente1 = dapper_repo.GetSementeCompleteByFrutaId(1);

            Semente semente2 = dapper_repo.GetSementeByFrutaId(1);

            Console.WriteLine("Hello");
        }
    }
}
