using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace QuestApp.Domain
{
    [Table("Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid UserId { get; set; }
        public string Name { get; set; }

        [InverseProperty("User")]
        public ICollection<Quest>? Quests { get; set; }    
        public User(Guid userId, string name)
        {
            UserId = userId;
            Name = name;
        }

    }
}
