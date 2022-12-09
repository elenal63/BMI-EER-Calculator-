//convert string pa to double depending on category
//convert weight and height before using it in findEeer
public class EerCalc:HealthCalculations
{
    public double paNum;
    public double eerResult;
    public double convertPaToDouble(string pa, string sex){
        if (sex == "m"){
            if (pa == "s"){
                paNum = 1.0;
            }
            else if (pa == "la"){
                paNum = 1.11;
            }
            else if (pa == "a"){
                paNum = 1.25;
            }
            else if (pa == "va"){
                paNum = 1.48;
            }
        }
        else if (sex == "f"){
            if (pa == "s"){
                paNum = 1.0;
            }
            else if (pa == "la"){
                paNum = 1.12;
            }
            else if (pa == "a"){
                paNum = 1.27;
            }
            else if (pa == "va"){
                paNum = 1.45;
            }
        }
        return paNum; 
    }
    public double findEer(Person Person){
        double newWeight = lbsToKg(Person.weight);
        double newHeight = inToM(Person.height);
        double pa = convertPaToDouble(Person.physicalActivity, Person.sex);

        if (Person.sex == "m" && (Person.age >= 3 || Person.age <= 8)){
            eerResult = eer(88.5, 61.9, Person.age, pa, 26.7, newWeight, 903, newHeight, 20);
        }
        else if (Person.sex == "m" && (Person.age >= 9 || Person.age <= 18)){
            eerResult = eer(88.5, 61.9, Person.age, pa, 26.7, newWeight, 903, newHeight, 25);
        }
        else if (Person.sex == "m" && Person.age >= 19){
            eerResult = eer(662, 9.53, Person.age, pa, 15.91, newWeight, 539.6, newHeight, 0);
        }
        else if (Person.sex == "f" && (Person.age >= 3 || Person.age <= 8)){
            eerResult = eer(135.3, 30.8, Person.age, pa, 10, newWeight, 934, newHeight, 20);
        }
        else if (Person.sex == "f" && (Person.age >= 9 || Person.age <= 18)){
            eerResult = eer(135.3, 30.8, Person.age, pa, 10, newWeight, 934, newHeight, 25);
        }
        else if (Person.sex == "f" && Person.age >= 19){
            eerResult = eer(354, 6.91, Person.age, pa, 9.36, newWeight, 726, newHeight, 0);
        }
        return Math.Round(eerResult, 2);
    }
}