public class Person 
{
    private int height; //Height in inches
    private int weight; //Weight in pounds
    private int age;
    private string sex = "";
    private string physicalActivity = ""; //Sedentary, Low Active, Active, Very Active 

    public void setHeight(int hei){
        height = hei;
    }
    public void setWeight(int wei){
        weight = wei;
    }
    public void setAge(int a){
        age = a;
    }
    public void setSex(string gender){
        sex = gender;
    }
    public void setPhysicalActivity(string pa){
        physicalActivity = pa;
    }

}