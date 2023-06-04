using QuestApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestApp.Domain
{
    [Table("Quests")]
    public class Quest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public required Guid Id { get; set; }
        public required string Name { get; set; }    
        public required string Description { get; set; }
        public int Reward { get; set; }
        public Difficulty Difficulty { get; set; }
        public bool IsRepeatable { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime TargetFinish { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        
        public User? User { get; set; }

        public Quest(Guid id, string name, string description, int reward, Difficulty difficulty, Boolean isRepeatable, DateTime targetFinish)
        {
            Id = id;
            Name = name;
            Description = description;
            Reward = reward;
            Difficulty = difficulty;
            IsRepeatable = isRepeatable;
            TargetFinish = targetFinish;
        }

    }
}
