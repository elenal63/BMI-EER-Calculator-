public class BmiCalc: Person 
{
    public object createPerson(){
    Person Person1 = new Person();
    Person1.setHeight(72);
    Person1.setWeight(180);
    Person1.setAge(22);
    Person1.setPhysicalActivity("active");
    Person1.setPhysicalActivity("m");

    return Person1;
    }
    
    public double getBmi(int weight, int height){
        double bmi = (weight * 703) / (height * height);
        return bmi;
    }
    // public string bmiResults(){
    // return Console.WriteLine("Your bmi is: " + getBmi(180, 72));
    // }
    
}