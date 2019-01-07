using System;
using SportStoreEF.Data;

namespace SportStoreEF {
    class Program {
        static void Main(string[] args) {
            using (ApplicationDbContext _context = new ApplicationDbContext()) {
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();
                Console.WriteLine("Database created...");
                SportsStoreDataInitializer.InitializeData(_context);
                Console.WriteLine("Database seeded...");
                Console.ReadLine();
            }
        }
    }
}
