public class BmiCalc:Person
{
    // public object createPerson(){
    // Person Person1 = new Person();
    // Person1.setHeight(72);
    // Person1.setWeight(180);
    // Person1.setAge(22);
    // Person1.setPhysicalActivity("active");
    // Person1.setPhysicalActivity("m");

    // return Person1;
    // }
    Person Person1 = new Person(68, 120, 20, "f", "la");
    public double getBmi(){ //maybe try including parameters
        double bmi = (Person1.weight * 703) / (Person1.height * Person1.height);
        return bmi;
    }
    // public string bmiResults(){
    // return Console.WriteLine("Your bmi is: " + getBmi(180, 72));
    // }
    
}