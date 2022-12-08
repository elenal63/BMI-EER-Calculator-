//convert string pa to double depending on category
//convert weight and height before using it in findEeer
public class EerCalc:HealthCalculations
{
    public double findEer(){
        double eerResult;
        if (sex == "m" && (age >= 3 || age <= 8)){
            eerResult = eer(88.5, 61.9, age, physicalActivity, 26.7, weight, 903, height, 20);
        }
        else if (sex == "m" && (age >= 9 || age <= 18)){
            eerResult = eer(88.5, 61.9, age, physicalActivity, 26.7, weight, 903, height, 25);
        }
        else if (sex == "m" && age >= 19){
            eerResult = eer(662, 9.53, age, physicalActivity, 15.91, weight, 539.6, height, 0);
        }
        else if (sex == "f" && (age >= 3 || age <= 8)){
            eerResult = eer(135.3, 30.8, age, physicalActivity, 10, weight, 934, height, 20);
        }
        else if (sex == "f" && (age >= 9 || age <= 18)){
            eerResult = eer(135.3, 30.8, age, physicalActivity, 10, weight, 934, height, 25);
        }
        else if (sex == "m" && age >= 19){
            eerResult = eer(354, 6.91, age, physicalActivity, 9.36, weight, 726, height, 0);
        }
        return eerResult;
    }
}