using System;

namespace SportStoreEF {
    class Program {
        static void Main(string[] args) {
            using (ApplicationDbContext _context = new ApplicationDbContext()) {
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();
                Console.WriteLine("Database created...");
                Console.ReadLine();
            }
        }
    }
}
