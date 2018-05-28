using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMain;
//using EFMain.Migrations;

namespace EFSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Configuration>());

            using (MyDbContext context = new MyDbContext())
            {
                context.MyEntities.FirstOrDefault();
            }

            Console.WriteLine("Complete");
            Console.Read();
        }
    }
}
