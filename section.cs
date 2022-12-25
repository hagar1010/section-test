using System;

namespace hagar;


// //inheritance*****   (class level)

// public abstract class Car{                //if we have abstract method then class will be abstract
//     // 2 referances
//     public string Name;   //private string _name      (using _ for private)
//     public string Color;

//     // 0 referance
//     public Car(){}

//     // 1 referance
//     //****consructor :-     (no return type)
//     public Car(string name ,string color){
//         Name = name;
//         Color = color;
//     }

//     public abstract void start();                    //abstract ==> method don't have declear      //حتكون في الاولاد وليست في الاب

//     public void stop(){}                            //shoudn't put base.  in child

//     // 1 referance 
//     public virtual void Print(){             //void*      virtual ==> we can rewrite it
//         Console.WriteLine($"Car: {Name}, Color: {Color}");
//     }
// }




// public class ElectricCar : Car{                     //inheirtance ==> electric = Car **exept ( constructor & private members )
//     public int Battry;

//     public ElectricCar(string name ,string color , int battry)   // : base( )              ??????مش حتفرق
//     {
//         Name = name;
//         Color = color;
//         Battry = battry;
//     }


//     public override void start(){                     //if there isn't override of abstract method(start)  then should make electricCar ==> abstract class       
//         Console.WriteLine("starting...");
//     }

//     //override (to output battry also)          ***can't override methods not virtual
//     public sealed override void Print(){                   //sealed method ==> can't override in cildren
//         stop();
//         base.Print();                         //shoud be virtual(overrided) to update    //تشبه this     //للزياده عن الدالة الاساسية
//         Console.WriteLine($"Battry: {Battry}");           //لا نحتاج نعيد الاسم واللون 
//     }



//     // public void A(){               //using Print() like perant
//     //     Print();
//     // }

// }





// public sealed class Tesla : ElectricCar{                              //sealed ==> class can't inheir from it
//     public Tesla(string color , int battry) : base("Tesla",color,battry){      //override in constractor
//     }
// }





// // 0 referance 
// class Section
// {
//     // 0 referance 
//     private static void Main() { 
//         Console.Write("Name is : ");
//         var name=Console.ReadLine();
//         Console.Write("Color is : ");
//         var color=Console.ReadLine();

//         // var car=new Car(name,color);                    //can't make insance(obj) from abstract type class
//         //or by inheirtance
//         // var car=new ElectricCar(name,color,100);
//         var car=new Tesla(color,100);     //لا نحتاج تعريف الاسم فوق

//         car.Print();
//     }
// }












































//polymorphism*****      (obj level)       //قدرة الابجكت انه ياخد اكثر من شكل

public abstract class Car{                //if we have abstract method then class will be abstract
    public string Name;   //private string _name      (using _ for private)
    public string Color;

    public Car(){}

    public Car(string name ,string color){
        Name = name;
        Color = color;
    }              


    public virtual void Print(){
        Console.WriteLine($"Car: {Name}, Color: {Color}");
    }
}






public class ElectricCar : Car{  
    public int Battry;

    public ElectricCar(string name ,string color , int battry)
    {
        Name = name;
        Color = color;
        Battry = battry;
    }

    public sealed override void Print(){                   //sealed method ==> can't override in cildren
        base.Print();                         
        Console.WriteLine($"Battry: {Battry}");           //لا نحتاج نعيد الاسم واللون 
    }

}




public sealed class Tesla : ElectricCar{        
    public Tesla(string color , int battry) : base("Tesla",color,battry){      //override in constractor
    }

    public void Start(){
        Console.WriteLine("Starting.....");
    }
}

public sealed class Nissan : Car{        
    public Nissan(string color) : base("Nissan",color){      //override in constractor
    }
}




class Section
{
    private static void Main() { 
        Console.Write("Color is : ");
        var color=Console.ReadLine();

        // Tesla car=new Tesla(color,100);     //type ==> Tesla
        // ElectricCar car=new Tesla(color,100);   //فكرة التراكم  
        // Car car=new Nissan(color);                   //the best because Car is the basic****
        Car car=new Tesla(color,100);                   //Car ==> defintion type  ,Tesla ==> impementation type ********


        // object car=new Tesla(color,100);        //error with Print()


        PrintCar(car);
        // car.Start();                  //error no defintion car
    }

    private static void PrintCar(Car car){
        car.Print();                      //callback print in object car that could be tesla or nisan 
    }
}




