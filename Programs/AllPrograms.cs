using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllPrograms.Programs.Inheritance;
namespace AllPrograms
{
    public class AllPrograms
    {
        public void RunAllPrograms()
        {
            #region Week 1 CSharp 

            #region 0. Story Of DotNet
            //  https://docs.google.com/document/d/1-DZprzkR6VPIIdk3Ks_ti404GG7Kq5utHxpSeZY02Qw/edit
            #endregion

            #region 1. Hello World
            //HelloWorld helloWorld = new HelloWorld();
            //helloWorld.PrintHelloWorld();
            #endregion

            #region 2. Variable and DataTypes
            //https://www.w3schools.com/cs/cs_variables.php

            //Difference between data type and variable
            //a variable is a storage location paired with an associated symbolic name, which contains 
            //some known or unknown quantity of information referred to as a value.The data type of a variable 
            //determines what kind of data it can hold and how much space it takes up.For example, an int data type
            //can hold integer values, while a string data type can hold sequences of characters.

            //Here’s a simple analogy: think of a variable as a cup that holds your coffee, and the data type as the size 
            //of the cup which determines how much coffee it can hold.
            #endregion

            #region 3. Float and double
            ////while working with float it must be use 'F' or 'f' at the end otherwise it thinks it as a double and gives you error.
            //// float range is 6 - 7 digit
            //float a = 3.1234567890123456789f;
            ////float b = 3.1234567890123456789;
            ////float c = 3.1234567890123456789d;

            //// double range is 14 - 15 digit
            //double x = 3.1234567890123456789f; // will give you wrong value as you provide wrong extension to the double
            //double y = 3.1234567890123456789;
            //double z = 3.1234567890123456789d;
            //Console.WriteLine(a);
            //// Console.WriteLine(b);
            ////Console.WriteLine(c);

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            #endregion

            #region 4. implicit and explicit type casting
            // https://www.w3schools.com/cs/cs_type_casting.php
            #endregion

            #region 5. implicitly typed local variables (var keyword)
            //There’s only one kind of implicitly typed local variable in C#, and it’s defined using var.

            // Case 1 : 
            //    An implicitly typed local variable is created by using the var keyword followed by a variable 
            //    initialization. For example:

            //    var message = "Hello world!";

            //    In this example, a string variable was created using the var keyword instead of the string keyword.
            //    the message variable is typed to be a string and can never be changed.
            //    For example, consider the following code:

            //    var message = "Hello World!";
            //    message = 10.703m;

            //    You get error here. 

            //Case 2 : 
            //    It's important to understand that the var keyword is dependent on the value you use to 
            //    initialize the variable. If you try to use the var keyword without initializing the variable, 
            //    you'll receive an error when you attempt to compile your code.

            //    var message;
            //          If you attempt to run this code, as it compiles, you'll see the following output:
            //    Output
            //    error CS0818: Implicitly - typed variables must be initialized


            //Case3:
            //    When you begin developing code for a task, you may not immediately know what data type to use.
            //    Using var can help you develop your solution more dynamically.



            #endregion

            #region 6. String
            // Refer doc for this topic
            //Character escape sequences
            //Verbatim string literal
            //string interpolation
            #endregion

            #region 7. conditional Statements and Loops
            // refer w3 school
            #endregion

            #region 8. Array
            //// Create an array of four elements, and add values later
            //string[] cars = new string[4];

            //// Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            #endregion

            #region 9. Function/Method
            // refer w3school
            #endregion

            // send this url for next session prelearning
            //https://www.c-sharpcorner.com/article/deep-dive-into-classes-and-objects/
            #endregion

            #region 10. Classes and object
            //Don't you ever think that you should create your own data type? Sometimes you have to store a bunch of data, like user information, and there might be multiple users, each with multiple different types of data, such as a name (string) and age (int). Suppose you have 10 users; how do you manage this? Would you create variables like user1_name, user1_age, user2_name, user2_age, and so on? Even if it's okay for a couple of users or limited information about a user, if there are numerous users and each user contains a lot of information, it would seem tedious and complicated.
            // here is the concept of classes.
            #endregion

            #region 11. Constructor
            /*Whenever you create an object, it means you specify a space for an object. Like when you create an object 
             of a car inside the memory, there would be a specified space allocated for you to perform some operations.

            When you create an object from a class, you assume that the object now exists. If you suppose a car, there 
            should be a default color, even if you don't paint it; it should be a color, even if it's like steel.

            You set these default values through a constructor. We are not doing this manually by calling this method. 
            We want it to do it automatically when we create an object of a class. That's one of the properties of a 
            constructor: it is called automatically.

            We are even though assigning some values automatically, meaning doing some operations. And one which performs 
            any operation in our programming is a function. So, the constructor is like a function.
            
            But why don't we say it as a function? Why do we separately name it as a constructor? 
            Because it does not return anything.

             */

            //// by default set values.
            //ConstructorOfCar constructorOfCar = new ConstructorOfCar();
            //constructorOfCar.drive();
            //constructorOfCar.whatsTheColor();


            //// set values from in the instantiation
            //ConstructorOfCar constructorOfCar1 = new ConstructorOfCar("blue");
            //constructorOfCar1.drive();
            //constructorOfCar1.whatsTheColor();
            #endregion

            #region 12. Inheritance

            //// single inheritance
            //Car car = new Car();
            //car.start();
            //car.StartAtSpeed(100);
            //car.canWeGoForLongDrive();

            // multilevel inheritance
            //Bulldozer bulldozer = new Bulldozer();
            //bulldozer.start();
            //bulldozer.StartAtSpeed(100);
            //bulldozer.canWeGoForLongDrive();

            #endregion

            #region 13. Interface
            // use my docs to people understand
            // rest we will learn while createing project
            #endregion

            #region 14. Access specifier/ Modifier
            // refer w3school
            #endregion

            #region 15. Properties
            // properties you will learn this in entity framework
            #endregion

        }
    }
}
