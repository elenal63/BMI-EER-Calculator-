public class BmiCalc
{
    public double getBmi(Person Person){ //maybe try including parameters
        double bmi = (Person.weight * 703) / (Person.height * Person.height);
        return Math.Round(bmi, 2);
    }
    
}