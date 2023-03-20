namespace LINQ
{

    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
            var nineteenHundreds = from s in stemPeople
                                   where s.BirthYear > 1900
                                   select s;

            Console.WriteLine("STEM People born after 1900:");
            foreach (var t in nineteenHundreds)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();

            var doubleL = from s in stemPeople
                          where s.Name.Contains("ll")
                          select s;

            Console.WriteLine("STEM People with 2 lowercase Ls in their name:");
            foreach (var t in doubleL)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine();

            var countPeople = from peo in stemPeople
                              where peo.BirthYear > 1950
                              select peo;
            var countPeople1 = countPeople.Count();
            Console.WriteLine("The number of STEM people born after 1950: " + countPeople1);
            Console.WriteLine();

            Console.WriteLine("The names of the people born between 1920 and 2000:");
            var birthCount = from stm in stemPeople
                             where stm.BirthYear > 1920
                             where stm.BirthYear < 2000
                             orderby stm.BirthYear
                             select stm;
            foreach (var b in birthCount)
            {
                Console.WriteLine(b.Name);
            }
            Console.WriteLine();

            var birthCount1 = birthCount.Count();
            Console.WriteLine("The number of people born between 1920 aand 2000 is " + birthCount1);
            Console.WriteLine();

            Console.WriteLine("The names of the people who died between 1960 and 2015:");
            var deathCount = from stp in stemPeople
                             where stp.DeathYear > 1960
                             where stp.DeathYear < 2015
                                        orderby stp.Name
                             select stp;
            foreach (var d in deathCount)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine();

        }
    }
}
