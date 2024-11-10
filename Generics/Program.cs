namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>(); 
            ICollection<string> collection = new HashSet<string>(); 
            IEnumerable<string> collection2 = new HashSet<string>();
            IQueryable<string> query = null;


            //Print("test");

            //Print(5);
            //Print(10.5);

            var any = new Any<int>();
           
            any.Add(1);
            any.Add(2);
            any.Add(3);
            any.Add(4);
            any.Display();

            var person = new Any<Person>();
            person.Add(new Person ("Mohamed","Ibrahim"));
            person.Add(new Person ("Ahmed","Mohamed"));
            person.Display();
            
        }
        public static void Print<T>(T text)
        {
            
            Console.WriteLine(text);
        }
        
        class Any<T>
        {

            public List<T> List = new List<T>();

            public void Add(T item)
            {
                List.Add(item);
            }
            public void Remove(T item)
            {
                List.Remove(item);
            }
            public void Display()
            { 
                foreach(var item in List)
                {
                    Console.WriteLine(item);
                }
            }
        }

        class Person
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public Person(string fname,string lname)
            {
                FName = fname;
                LName = lname;
            }
            public override string ToString()
            {
                return $"Name : {FName} {LName}";
            }
        }


    }
}
