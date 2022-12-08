//convert string pa to double depending on category
//convert weight and height before using it in findEeer
public class EerCalc:HealthCalculations
{
    public double convertPaToDouble(string pa, string sex){
        double paNum;
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
    public double findEer(double weight, double height, string sex, string pa, int age){
        double eerResult;
        double newWeight = lbsToKg(weight);
        double newHeight = inToM(height);
        double physicalActivity = convertPaToDouble(pa, sex);

        if (sex == "m" && (age >= 3 || age <= 8)){
            eerResult = eer(88.5, 61.9, age, physicalActivity, 26.7, newWeight, 903, newHeight, 20);
        }
        else if (sex == "m" && (age >= 9 || age <= 18)){
            eerResult = eer(88.5, 61.9, age, physicalActivity, 26.7, newWeight, 903, newHeight, 25);
        }
        else if (sex == "m" && age >= 19){
            eerResult = eer(662, 9.53, age, physicalActivity, 15.91, newWeight, 539.6, newHeight, 0);
        }
        else if (sex == "f" && (age >= 3 || age <= 8)){
            eerResult = eer(135.3, 30.8, age, physicalActivity, 10, newWeight, 934, newHeight, 20);
        }
        else if (sex == "f" && (age >= 9 || age <= 18)){
            eerResult = eer(135.3, 30.8, age, physicalActivity, 10, newWeight, 934, newHeight, 25);
        }
        else if (sex == "m" && age >= 19){
            eerResult = eer(354, 6.91, age, physicalActivity, 9.36, newWeight, 726, newHeight, 0);
        }
        return eerResult;
    }
}