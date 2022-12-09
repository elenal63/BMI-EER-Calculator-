public class HealthCategory:BmiCalc
{
    public string category = "";
    //public string plan = "";
    public string findCategory(Person Person){
    
        if (getBmi(Person) <= 18.5){
            category = "underweight";
        }
        else if (getBmi(Person) >= 18.5 || getBmi(Person) <= 24.9){
            category = "healthy weight";
        }
        else if (getBmi(Person) >= 25.0 || getBmi(Person) <= 29.9){
            category = "obese";
        }
        else if (getBmi(Person) <= 30){
            category = "extreme obesity";
        }

        return category; 
    }

    // public string actionPlan(){
    //     if (findCategory() == "underweight"){
    //         plan = "Try consuming 500-1,000 Calories more each day. Also eat more nutrient dense foods including each food group."
    //     }
    //     return plan;
    // }
}