using PropertyTypesdemo;





class Program
{
    static void Main(string[] args)
    {
        List<PersonModel> people = new List<PersonModel>();
        List<AddressModel> addresses = new List<AddressModel>();
        
        PersonModel person = new PersonModel();
        person.FirstName = "Tim";
        person.LastName = "Corey";
        person.Age = 42;
        person.SSN = "123-45-6789";
        people.Add(person);

        person = new PersonModel();
        person.FirstName = "Arrenzo";
        person.SSN = "060-32-9648";
        people.Add(person);

        AddressModel address = new AddressModel();
        address.StreetAddress = "123 Main St";
        address.City = "Pittsburgh";
        address.State = "PA";
        address.ZipCode = "15222";
        address.UserName = "arrenzo";
        addresses.Add(address);

        address = new AddressModel();
        address.StreetAddress = "123 Main St";
        address.City = "Pittsburgh";
        address.State = "PA";
        address.ZipCode = "15222";
        address.UserName = "umar";
        addresses.Add(address);


        foreach (PersonModel p in people)
        {
            Console.WriteLine();
        Console.WriteLine($"First name: {p.FirstName}\n Last name: {p.LastName} \n Age: {p.Age} \n SSN: {p.SSN}");
        

       }

        foreach (AddressModel a in addresses)
        {
            Console.WriteLine();
            Console.WriteLine($"Street Address: {a.StreetAddress}\n City: {a.City}\n State: {a.State}\n Zip Code: {a.ZipCode}\n User Name: {a.UserName}");
        }










        Console.ReadLine();
    }
}