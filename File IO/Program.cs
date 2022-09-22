using File_IO;

var root = FileRoot.fileRoot;
char dirSep = Path.DirectorySeparatorChar;
var file = root + dirSep + "data.csv";
var newFile = root + dirSep + "data.psv";

var people = new List<Person>();

using (var sr = new StreamReader(file))
{
    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var info = line.Split(",");

        var firstname = info[0];
        var lastname = info[1];
        var address1 = info[2];
        var City = info[3];
        var State = info[4];
        var PostalCode = info[5];

        Address a = new Address(address1, City, State, PostalCode);

        people.Add(new Person(firstname, lastname, a));
    }

    Console.WriteLine("Sorting...");
    people.Sort();

    Console.WriteLine("Creating PSV File");
    using (var sw = new StreamWriter(newFile, append: false))
    {
        foreach(Person person in people)
        {
            string line = person.ToString();
            sw.WriteLine(line);
        }
    }
}