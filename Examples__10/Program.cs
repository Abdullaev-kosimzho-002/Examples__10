// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Task 1.
/*class MyFriend
{
    private string name;

    public void Help()
    {
        name = "Help me please open the door";
        Console.WriteLine(name);
    }
}
class Program
{
    static void Main()
    {

        MyFriend person = new MyFriend();
        person.Help();
    }
}
*/


//Test 2.
/*
class College
{
    public string olya = "Olya";
    string richard = "Vlad";
    public const string Lola = "Lola";
    public readonly int age;

   
    public College(int year)
    {
        age = year;
    }
    
    
    public string Olya
    {
        get
        {
            return olya;
        }
        set { }
    }
    public string Richard
    {
        get
        {
            if (richard == "Vasya" || richard == "Sanya")
            {
                return richard;
             //   Console.WriteLine("Одно из них ");
            }
            else
            {
                return "Он нолик";
            }
        }
        set
        {

        }
    }
   
    
    
    public void Method_1()
    {
        Console.WriteLine(richard);
        Console.WriteLine(Lola);
    
    
    }



}
class Program
{
    static void Main()
    {
        College myCollege = new College(10);
        myCollege.Method_1();
        myCollege.Richard = "Zinaida";
        Console.WriteLine(myCollege.Richard);

    }
}
*/

//Task 3.
/*
class Wedding
{
    public string invite;
    private int quintity = 1000;
    public string order;

    public Wedding(string people)
    {
        invite = people;
    }
    public int Quint
    {
        set
        {
            if (value <= 100)
            {
                Console.WriteLine("Сто стульев заказали");
            }
            else if (value >= 100)
            {
                Console.WriteLine("Больше сто стульев заказали");
            }
            else
            {
                Console.WriteLine("Вообще не заказали");
            }

        }
        get
        {
            return quintity;
        }
    }
    public void Ordered(string restaurant)
    {
        order = restaurant;
        Console.WriteLine(order);
    }

}

class Program
{
    static void Main()
    {
        Wedding myWedding = new Wedding("Мы пригласим 500 гостей");
        myWedding.Quint = 2000;
        Console.WriteLine(myWedding.Quint);
        myWedding.Ordered("Durahshon");
    }
}
*/












































































