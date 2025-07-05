/*

ТИПИ ВЗАЄМОДІЇ ОБ\ЄКТІВ

1. АГРЕГАЦІЯ
2. КОМПОЗИЦІЯ
3. ЗАЛЕЖНІСТЬ
4. АСОЦІАЦІЯ


*/


// 1. АГРЕГАЦІЯ

// один обʼєкт "включає" інший, але може існувати і окремо самостійно

class Engine
{
    public void Start()
    {
        System.Console.WriteLine("Engine started");
    }
}

class Car
{
    private Engine engine;
    public Car(Engine engine)
    {
        this.engine = engine;
    }
    public void Drive()
    {
        engine.Start();
        System.Console.WriteLine("car is driving");
    }

}

var engine = new Engine();
var car = new Car(engine);
car.Drive();

// 2. КОМПОЗИЦІЯ

// один обʼєкт повністю володіє іншим. коли "власник" знищується то і зникає "включений" обʼєкт

class Processor()
{
    public void Calculate()
    {
        System.Console.WriteLine("Processor calculating");
    }
}

class Computer
{
    private Processor processor;
    public Computer()
    {
        processor = new Processor();
    }
    public void Run()
    {
        processor.Calculate();
        System.Console.WriteLine("Computer is running");
    }
}


// 3. ЗАЛЕЖНІСТЬ

// один обʼєкт тимчасово використвує інший у межах певного !методу!

class Document
{
    string title;
    public string Title { get; set; }
}

class Printer
{
    public void Print(Document doc)
    {
        Console.WriteLine($"Printing document: {doc.Title}");
    }
}
class Program {
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        Document document = new Document { Title = "report" };
        printer.Print(document);     //Printing document: report
    }
}

// 4. АСОЦІАЦІЯ

// загальний звʼязок між двома класами
class Student
{
    public string Name { get; set; }
    public Teacher Mentor{ get; set; }

}

class Teacher
{
    public string Name { get; set; }
    public Student PersonalStudent { get; set; }
}

class Director
{
    public string Name { get; set; }
}

// компʼютер та його компоненти

// Computer - головний клас, який поєднує всі інші
// Processor, Memory, Storage - створюється всередині Computer - *композиція
// Keyboard, Monitor - передаєтсья ззовні - *агрегація
// User - користується Computer - *асоціація 
// метод InstallSoftwate(Software soft) - залежність
