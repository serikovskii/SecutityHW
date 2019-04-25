namespace SecurityHW
{
    using System.Data.Entity;

    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext")
        {
        }
        public virtual DbSet<Visitor> Visitors { get; set; }
    }
}