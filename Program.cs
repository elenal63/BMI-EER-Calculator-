class Program
{
    static void Main(string[] args)
    {
        
        
        //Ask user for each variable and assign them, then create object
        Console.Write("\nEnter your height(in.):\t");
        double userHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter your weight(lbs.):\t");
        double userWeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter your age:\t");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter your sex('m' or 'f'):\t");
        string userSex = Console.ReadLine()??"";
        //add an explaination of pa levels 
        Console.Write("\nEnter your physical activity('s', 'la', 'a', or 'va'):\t");
        string userPa = Console.ReadLine()??"";

        Person Person1 = new Person(userHeight, userWeight, userAge, userSex, userPa);

        EerCalc Eer = new EerCalc();
        double eerResult = Eer.findEer(Person1);
        Console.WriteLine($"Your estimated energy requirment is: {eerResult} kcals/day");

        BmiCalc Bmi = new BmiCalc();
        double bmiResult = Bmi.getBmi(Person1);
        Console.WriteLine($"Your bmi is: {bmiResult}");

        HealthActions Action = new HealthActions();
        string cat = Action.findCategory(Person1);
        Console.WriteLine($"You fall in the {cat} category.");

        //BmiCalc.getBmi(Person1.getHeight(), Person1.getWeight());

    }
}