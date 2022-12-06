public class Person 
{
    internal int height; //Height in inches
    internal int weight; //Weight in pounds
    internal int age;
    internal string sex = "";
    internal string physicalActivity = ""; //Sedentary, Low Active, Active, Very Active 

//getters

    public int getHeight(){
        return height;
    }
    public int getWeight(){
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
//setters
    public void setHeight(int height){
        this.height = height;
    }
    public void setWeight(int weight){
        this.weight = weight;
    }
    public void setAge(int age){
        this.age = age;
    }
    public void setSex(string sex){
        this.sex = sex;
    }
    public void setPhysicalActivity(string physicalActivity){
        this.physicalActivity = physicalActivity;
    }
}