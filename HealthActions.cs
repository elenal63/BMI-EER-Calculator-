public class HealthActions:BmiCalc
{
    public string category = "";
    public string findCategory(){
    
        if (getBmi() <= 18.5){
            category = "underweight";
        }
        else if (getBmi() >= 18.5 || getBmi() <= 24.9){
            category = "healthy weight";
        }
        else if (getBmi() >= 25.0 || getBmi() <= 29.9){
            category = "obese";
        }
        else (getBmi() <= 30){
            category = "extreme obesity";
        }

        return category; 
    }
}