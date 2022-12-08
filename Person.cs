public class Person 
{
    internal double height; //Height in inches
    internal double weight; //Weight in pounds
    internal int age;
    internal string sex = "";
    internal string physicalActivity = ""; //Sedentary, Low Active, Active, Very Active 

    public Person(){

    }
//getters

    public double getHeight(){
        return height;
    }
    public double getWeight(){
        return weight;
    }
    public int getAge(){
        return age;
    }
    public string getPhysicalActivity(){
        return physicalActivity;
    }
    public string getSex(){
        return sex;
    }
//class constructor 
    public Person(double height, double weight, int age, string sex, string physicalActivity){
        this.height = height;
        this.weight = weight;
        this.age = age;
        this.sex = sex;
        this.physicalActivity = physicalActivity;
    }

}