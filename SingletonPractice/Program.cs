internal class Program
{
    private static void Main(string[] args)
    {
        Computer computer = new Computer();
        computer.Launch("Linux");
        Console.WriteLine(computer.OS.Name);

        //(это не сработает кст, прикол сингла, инстанс уже создан, его не изменить)
        computer.OS = OS.getInstance("Windows seven");
        Console.WriteLine(computer.OS.Name);

        Console.ReadKey();
    }
}

//class Singleton
//{
//    private static Singleton Instance;

//    private Singleton() { }

//    public static Singleton GetInstance()
//    {
//        if(Instance == null)
//            Instance = new Singleton();
//        return Instance;
//    }
//}

class Computer
{
    public OS OS { get; set; }

    public void Launch(string osName)
    {
        OS = OS.getInstance(osName);
    }
}

class OS
{
    private static OS Instance;

    public string Name { get; set;}

    protected OS(string name) 
    {
        this.Name = name;
    }

    public static OS getInstance(string name)
    {
        if (Instance == null)
            Instance = new OS(name);
        return Instance;
    }
}