namespace Nakia_amal.Models
{
    public class Reclamation
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Etat { get; set; } = null!;

        public int UserId { get; set; }

        public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

        public virtual User User { get; set; } = null!;
    }
}
