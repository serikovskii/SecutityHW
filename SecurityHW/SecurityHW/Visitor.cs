using System;

namespace SecurityHW
{
    public class Visitor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string IIN { get; set; }
        public string Purpose { get; set; }
        public DateTime DateTimeArrival { get; set; }
        public DateTime DateTimeDeparture { get; set; }

        public Visitor()
        {
            Id = Guid.NewGuid();
        }
    }
}
