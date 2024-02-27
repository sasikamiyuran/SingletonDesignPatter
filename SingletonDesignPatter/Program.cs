using SingletonDesignPatter;

Console.Title = "Singleton Design Pattern";

//call the proterty getter twice
var instence1 = Logger.Instance;
var instence2 = Logger.Instance;

if(instence1 == instence2 && instence1 == Logger.Instance)
{
    Console.WriteLine("Instence are same");
}

instence1.Log($"Message from {nameof(instence1)}");
instence2.Log($"Message from {nameof(instence2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.ReadLine();