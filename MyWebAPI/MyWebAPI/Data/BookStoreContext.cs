using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt )
            : base( opt ) 
        { 
             
        }

        #region DBSet
        public DbSet<Book>? Books { get; set; }

        #endregion
    }
}
