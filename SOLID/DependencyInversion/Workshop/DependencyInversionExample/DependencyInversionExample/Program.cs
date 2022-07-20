namespace DependencyInversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // fix dependency inversion and dependency injection

            var organization = new Organization("Formula F1");
            organization.Users.AddDriver(new Driver(0, "Max Verstapen", "Red Bull", new DateTime(1997, 9, 30)));
            organization.Users.AddDriver(new Driver(1, "Charles Leclerc", "Ferrari", new DateTime(1997, 10, 16)));
            organization.Users.AddDriver(new Driver(2, "Lewis Hamilton", "Mercedess", new DateTime(1985, 1, 7)));

            foreach (var driver in organization.Users.DriversYoungerThan(new DateTime(1990, 1, 1)))
            {
                Console.WriteLine(driver);
            }
        }
    }
}