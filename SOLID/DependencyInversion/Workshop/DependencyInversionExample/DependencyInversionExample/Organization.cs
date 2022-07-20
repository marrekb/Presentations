namespace DependencyInversionExample
{
    public class Organization
    {
        public string Name { get; set; }
        public DriverDatabase Users {get;}

        public Organization(string name)
        {
            name = Name;
            Users = new DriverDatabase();
        }

    }
}
