using MyFazendaFrame.Data;
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


            string id = Console.ReadLine();

            DapperRepository rep = new DapperRepository();

            Semente s = rep.GetSementeById(int.Parse(id));

            (decimal p, int q) = rep.GetSementeFrutaPrecoEmbalagemById(1);

            IEnumerable<Semente> seeds = rep.GetSementes();

            Console.WriteLine(p);
            Console.WriteLine(q);
        }
    }
}
