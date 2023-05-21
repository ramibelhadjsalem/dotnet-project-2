namespace Nakia_amal.Models
{
    public class Action
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int ReclamationId { get; set; }

        public virtual Reclamation Reclamation { get; set; } = null!;
    }
}
