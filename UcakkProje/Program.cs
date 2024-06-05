using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DemoForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //using (var dbContext = new HelloContext())
            //{
            //    var lsns = dbContext.Lessons.ToList();

            //    var tchrs = dbContext.Teachers.ToList();

            //    var newTchr = new Teacher() { name = "Salih", section = "Sağlık" };
            //    dbContext.Teachers.Add(newTchr);
            //    //tchrs.Add(newTchr);
            //    dbContext.SaveChanges();

                
            //    foreach (var ls in lsns)
            //    {
            //        Console.WriteLine(ls.CuurentTeacher.name);
            //    }

            //    // Yeni bir öğe ekleme
            //    var usrs = dbContext.Users.ToList();

            //    //dbContext.SaveChanges();

            //    // Veriye erişme
            //    //var entities = dbContext.MyEntities.ToList();
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
