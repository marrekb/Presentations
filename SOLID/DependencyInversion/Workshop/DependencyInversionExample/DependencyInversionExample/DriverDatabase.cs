namespace DependencyInversionExample
{
    public class DriverDatabase
    {
        private readonly HashSet<Driver> _users;

        public DriverDatabase()
        {
            _users = new HashSet<Driver>();
        }

        public bool AddDriver(Driver user)
        {
            return _users.Add(user);
        }

        public IEnumerable<Driver> AllDriver()
        {
            return _users;
        }

        public IEnumerable<Driver> DriversYoungerThan(DateTime dateTime)
        {
            return _users.Where(x => x.BirthDate >= dateTime);
        }

        public IEnumerable<Driver> DriversByName(string name)
        {
            return _users.Where(x => x.Name == name);
        }
    }
}
