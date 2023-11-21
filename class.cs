// class Car {
//     public string? model;
//     string? plate;
//     private int price;
// }


using System.Diagnostics.Contracts;

class Employee {
    public string? name;
    public string? position;
    private int salary;
    public int age;
    public string? address {get; set;}

    public int Salary {
        // get {return salary; }
        set {salary = value; }
    }

    public static void Print(Employee folan) {
        Console.WriteLine("Fullname : "+ folan.name);
        Console.WriteLine("Age : "+ folan.age);
        Console.WriteLine("Position : "+ folan.position);
        Console.WriteLine("Salary : "+ folan.salary);
    }
    

    // public static void Main(string[] args){
    //     Employee Moaz = new Employee();
    //     Moaz.name = "Moaz Mohamed";
    //     Moaz.position = "Developer";
    //     Moaz.age = 23;
    //     Moaz.Salary = 3000;
    //     Moaz.address = "14 st. lalaland";

    //     Console.WriteLine(Moaz.salary);

    //     Print(Moaz);
    // }
}

