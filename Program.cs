using System.Formats.Asn1;

namespace Mod1_Review;

class Program
{
    static void Main(string[] args)
    {
     ChooseShape();   //Calling the main method for the user.
    }

    static void ChooseShape()
    {
        // This function allows the user to choose the shape they want to know the area of.
        // The function will take in the user input and run the corresponding function.
        
        Console.WriteLine("What shape would you like to find the area for? ");
        string userChoice = Console.ReadLine();
        
        if (userChoice.ToUpper() == "CIRCLE")                  //Capitalizing user input so there will be no case discrepancies.
        {
            Console.WriteLine("What is the radius? ");
            double radius = Convert.ToDouble(Console.ReadLine());   //Converting the input string to type: Double.
            Circle(radius);                                         //Calling the corresponding function.
        }
        else if (userChoice.ToUpper() == "TRIANGLE")           //Utilizing else if in case the "if" statement requirements are not met.
        {
            Console.WriteLine("What is the base? ");
            double triBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height? ");
            double triheight = Convert.ToDouble(Console.ReadLine());
            Triangle(triBase, triheight);
        }
        else if (userChoice.ToUpper() == "RECTANGLE")
        {
            Console.WriteLine("What is the width? ");
            double recWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the Length? ");
            double recLength = Convert.ToDouble(Console.ReadLine());
            Rectangle(recWidth, recLength);
        }
        else if (userChoice.ToUpper() == "SQUARE")
        {
            Console.WriteLine("What is the side length? ");
            double side = Convert.ToDouble(Console.ReadLine());
            Square(side);
        }
        else
        {
            Console.WriteLine("This did not work bro...");         //else statement in case none of the requirements are met.
        }
    }

    static double Circle(double radius)
    {
        //This function takes in a "radius" argument and utilizes the .Pow method in order
        //to do the proper equation required to find the area of the circle.
        double area = 3.14 * Math.Pow(radius, 2);
        Console.WriteLine($"The area of the circle is {area}squared units"); //string interpolation to inform the user of the answer.
        return area;                                                           //returning the answer
    }
    
    static double Triangle(double tribase, double triheight)
    {
        //this function takes in 2 arguments "triBase" and "triHeight" to determine the area of the triangle.
        double area = .5 * tribase * triheight;
        Console.WriteLine($"The area of the triangle is {area}");
        return area;
    }
    
    static double Rectangle(double recWidth, double recLength)
    {
        //this function takes in 2 arguments "recWidth" and "recLength" to determine the area of the rectangle
        double area = recWidth * recLength;
        Console.WriteLine($"The area of the triangle is {area}");
        return area;
    }
    
    static double Square(double side)
    {
        //this function takes in a single argument "side" and utilizes the .Pow method to find the area of the square.
        double area = Math.Pow(side, 2);
        Console.WriteLine($"The area of the square is {area}");
        return area;
    }
    
    
    
}