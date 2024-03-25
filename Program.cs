namespace oop
{
    /* //first example to add two numbers
      internal class Cal
      {
          int num1;
          int num2;
          int result;
          void Add()
          {
              result= num1+num2;
              Console.WriteLine(result);
          }
          void Sub()
          {
              result = num1 - num2;
              Console.WriteLine(result);
          }
          static void Main(string[] args)
          {
             Cal obj = new Cal();
              obj.num1 = 20;
              obj.num2 = 10;
              obj.Add();
              obj.Sub();
          }
      }
    */
    /*  internal class Car
      {
          string model = "porsche";// fields
          string color =""; // fields
          public void fullThrottle()    // method
          {
              Console.WriteLine("The car is going as fast as it can!");
          }

          static void Main(string[] args)
          {
              Car myObj = new Car();
              myObj.fullThrottle();  // Call the method
          }


      } */

    //encapsulation
    /*class Account
    {
         int accountBalance=1000;
        
        public void SetBalance(int Amount)
        {
            accountBalance = Amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is :" +accountBalance);
        }
        // here we use set and get so it accountbalance can be acccess to class program
        public int Balance
        {
            set
            {
                accountBalance = value;
            }
            get
            {
                return accountBalance;
            }
        }
    }
    class Program
    {
            static void Main(string[] args)
        {
            Account myAccount = new Account();
            //we cant get accountbalance from class account because its private means encapsulate we get that by using set and get
            //myAccount.accountBalance=100;
            //myAccount.SetBalance(2000);
            //myAccount.GetBalance();
            myAccount.Balance = 45000;
            Console.WriteLine("Your Account Balance is "+ myAccount.Balance);
            Console.ReadLine();
            
        }
    }
    */

    //inheritance example start
    /* class Vehicle
     {
         public string model;
         public string color;
         public int price;

         public void printvehicleinfo()
         {
             Console.WriteLine("Model:" + model);
             Console.WriteLine("Color:" + color);
             Console.WriteLine("Price:" + price);
         }
     }

     class Mehran: Vehicle
     {
         float mileage;
         void PrintMileage()
         {
             Console.WriteLine("Mileage:" + mileage);
         }

         public static void Main(string[] args)
         {
             Mehran myCar = new Mehran();
             myCar.model = "Mehran Dashuza";
             myCar.color = "red";
             myCar.price = 2300000;
             myCar.mileage = 23.5f;
             myCar.printvehicleinfo();
             myCar.PrintMileage();
             Console.ReadLine();
         }
     }
     //inheritance example end
    */

    //Polymorphism Start
    //method Overloading
    /*class Maths
    {
        void Sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Maths objMaths = new Maths();
            objMaths.Sum(23.1f, 22.1f);
            objMaths.Sum(22, 22);
            Console.ReadLine();
        }
    }
    */
    //method overrriding
    /* class Animal  // Base class (parent) 
     {
         public virtual void animalSound()
         {
             Console.WriteLine("The animal makes a sound");
         }
     }

     class Pig : Animal  // Derived class (child) 
     {
         public override void animalSound()
         {
             Console.WriteLine("The pig says: wee wee");
         }
     }

     class Dog : Animal  // Derived class (child) 
     {
         public override void animalSound()
         {
             Console.WriteLine("The dog says: bow wow");
         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             Animal myAnimal = new Animal();  // Create a Animal object
             Animal myPig = new Pig();  // Create a Pig object
             Animal myDog = new Dog();  // Create a Dog object

             myAnimal.animalSound();
             myPig.animalSound();
             myDog.animalSound();
         }
     }
     //Polymorphism Ends
    */
    // interfaces & Abstraction
    //interface IAnimal
    //  {
    //      void animalSound();
    //  }
    //  class Dog : IAnimal
    //  {
    //      public void animalSound()
    //      {
    //          Console.WriteLine("The Dog is Barking");
    //      }
    //  }
    //  class All
    //  {
    //      static void Main(string[] args)
    //      {
    //          IAnimal petDog = new Dog();
    //          petDog.animalSound();
    //      }

    //  }



    //-------------------------------------------------------------------------------------------------//

    //Revision
    // Classes and Objects  
    //public class Cal1 //class
    //{
    //    int num1;
    //    int num2;
    //    int result;

    //    void add()
    //    {
    //        result = num1 + num2;
    //        Console.WriteLine(result);
    //        Console.ReadLine();
    //    }
    //    void sub()
    //    {
    //        result = num1 - num2;
    //        Console.WriteLine(result);
    //        Console.ReadLine();
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Cal1 ObjCal1 = new Cal1(); // object objcal1 created
    //        ObjCal1.num1 = 100;
    //        ObjCal1.num2 = 200;
    //        ObjCal1.add();  
    //        ObjCal1.sub();

    //        Cal1 ObjCal2 = new Cal1(); // object objcal2 created
    //        ObjCal2.num1 = 200;
    //        ObjCal2.num2 = 150;
    //        ObjCal2.add();
    //        ObjCal2.sub();
    //    }
    //}

    //Constructors
    //class Program // class 
    //{
    //    string name;
    //    int age;
    //    public Program(string fname, int fage) // constructor  same name as class name + Parametized Constructor
    //    {
    //        name = fname;
    //        age = fage;
    //       // Console.WriteLine("Hello i am a constructor");
    //    } 
    //    public static void Main(string[] args)
    //    {
    //        Program objProg = new Program("Sufiyan", 22); //giving parameter
    //        // object created objprog +  if you dont create constructor Program() constructor created automatically
    //        Console.WriteLine("Name :" + objProg.name);
    //        Console.WriteLine("Age :" + objProg.age);

    //    }
    //}

    //Encapsulation
    //“Encapsulation, is to make sure that "sensitive" data is hidden from users.”
    /**Q) How can we Achieve Encapsulation?
      Encapsulation can be achieve in two steps
             step-1 : Declare the value of a class as a private.
             step-2 : Provide public setter and getter methods to modify and view the variable values.*/
    //class Account
    //{
    //Declare the value of a class as a private , no access specifier on properties means private
    // int AccountBalance = 1000;

    //Provide public setter and getter methods to modify and view the variable values
    //set method - this method in encapsulation i can control everything that which value will enter and which can't.
    //public void setBalance(int Amount)
    //{
    //    if (Amount < 0)
    //    {
    //        Console.WriteLine("The Value is not acceptable");
    //    }
    //    else
    //    {
    //        AccountBalance = Amount;
    //    }

    //}
    ////get method
    //public void getBalance()
    //{
    //    Console.WriteLine("Your Account Balance is " + AccountBalance);
    //}


    // we can achieve this by using set and get properties(properties is a combination of variables and methods) 
    //    public int Balance
    //    {
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine("The Value is not acceptable");
    //            }
    //            else
    //            {
    //                AccountBalance = value;
    //            }

    //        }
    //        get
    //        {
    //            return AccountBalance;
    //        }
    //    }


    //}
    //class AcProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Account myAccount = new Account();
    //myAccount.setBalance(2000);
    //myAccount.getBalance();
    //myAccount.Balance = 2000;
    //Console.WriteLine("Your account Balance is "+ myAccount.Balance);
    //Console.ReadLine();
    //}
    //}


    //Inheritance 
    /*Inheritance is a mechanism of reusing the functionalities of one class into another related class.
     inheritence is used to make relations between class*/

    //class Car
    //{
    //    public string model;
    //    public string color;
    //    public int price;

    //    public void PrintCarInfo()
    //    {
    //        Console.WriteLine("Model : " + model);
    //        Console.WriteLine("Color : " + color);
    //        Console.WriteLine("Price : " + price);
    //    } 
    //}
    //class Maruti : Car
    //{
    //    float mileage;

    //    void printmileage()
    //    {
    //        Console.WriteLine("Mileage : " + mileage);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Maruti MyCar = new Maruti();
    //        MyCar.model = "Alto";
    //        MyCar.color = "red";
    //        MyCar.price = 100;
    //        MyCar.mileage = 22.5f;
    //        MyCar.PrintCarInfo();
    //        MyCar.printmileage();
    //    }
    //}

    //Polymorphism
    //Poly means many | Morphims means behaviour/forms
    /*There are two types of polymorphism , compile time polymorphism and run time polymorphism.
     * We can achieve compile time polymorphism with method overloading and
     * achieve run time polymorphism with method overriding.*/

    //Method Overloading
    //class Program
    //{
    //    void sum(int a , int b)
    //    {
    //        Console.WriteLine(a + b);
    //    } 
    //    void sum(float a , float b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    static void Main(String[] args) 
    //    {
    //        Program Obj = new Program();
    //        Obj.sum(20 , 25);
    //        Obj.sum(20.5f , 25.5f);
    //        Console.ReadLine();
    //    }
    //}

    //Method Overriding
    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal is eating! ");
    //    }
    //}
    //class Dog : Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Dog is eating! ");
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Dog tommy = new Dog();
    //        tommy.Eat();
    //    }
    //}

    // Abstraction & Interfaces
    //Abstraction can be achieved with either abstract classes or interfaces.
    //we cant create  a object of abstract class
    //abstract
    //abstract class Animal
    //{
    //    public abstract void Eat();
    //    class Dog : Animal
    //    {
    //        public override void Eat()
    //        {
    //            Console.WriteLine("Dog is eating! ");
    //        }
    //        public static void Main(string[] args)
    //        {
    //            Dog tommy = new Dog();
    //            tommy.Eat();
    //        }
    //    }
    //} 
}

