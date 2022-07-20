using System.Reflection.Metadata.Ecma335;

namespace DependencyInversionExample
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Team { get; set; }

        public DateTime BirthDate { get; }

        public Driver(int id, string name, string team, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Team = team;
            BirthDate = birthDate;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            var other = (Driver)obj;
            return other.Id == Id;
        }

        public override string ToString()
        {
            return $"Driver: {Name}, team: {Team}";
        }
    }
}