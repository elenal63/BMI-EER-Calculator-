public class HealthCalculations
{

    public double eer(double num, double num2, int age, double pa, double num3, double weight, double num4, double height, double num5){
        double eer = num - (num2 * age) + pa * ((num3 * weight) + (num4 * height)) + num5;
        return eer;
    }

    public double inToM(double inches){
        double meters = inches * 0.0254;
        return meters;
    }
    public double lbsToKg(double lbs){
        double kg = lbs * 0.45359237;
        return lbs;
    }
}