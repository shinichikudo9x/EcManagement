using GUI_Maker_ECManagement.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Maker_ECManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            //  Application.Run(new DanhSachLopHoc());
            string connectionString = "server=localhost;port=3305;database=ecdata;uid=root;pwd=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (AutoTable contextDB = new AutoTable(connection, false))
                {
                    contextDB.Database.CreateIfNotExists();
                }

                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // DbConnection that is already opened
                    using (AutoTable context = new AutoTable(connection, false))
                    {

                        // Interception/SQL logging
                        context.Database.Log = (string message) => { Console.WriteLine(message); };

                        // Passing an existing transaction to the context
                        context.Database.UseTransaction(transaction);

                        // DbSet.AddRange
                        List<User> cars = new List<User>();

                        cars.Add(new User());
                        cars.Add(new User());
                        cars.Add(new User());
                        cars.Add(new User());

                        context.Users.AddRange(cars);

                        context.SaveChanges();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AutoTable: DbContext
    {
        public DbSet<User> Users { get; set; }
        public AutoTable(DbConnection connection, bool contextConnection) : base(connection, contextConnection)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().MapToStoredProcedures();
        }
        //public DbSet<HocVien> HocViens { get; set; }
    }
}
