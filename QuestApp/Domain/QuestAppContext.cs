using Microsoft.EntityFrameworkCore;

namespace QuestApp.Domain
{
    public class QuestAppContext : DbContext
    {
        public QuestAppContext(DbContextOptions<QuestAppContext> options)
            : base(options)
        {
        }

        public DbSet<Quest> Quests { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
