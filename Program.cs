/*Author : Bongani Gadlela
 * Program Descrption : calculate and displays diameter,area and circumference
 */

//project packages
namespace CatchUpDiameterCircumArea
{
    //class definition begins here
    internal class Program
    {
        //program execution begins here
        static void Main(string[] args)
        {
            //declare variables
            int radius;                 //input
            double diameter;            //output
            double area;                //output
            double circumference;       //output

            Console.WriteLine("Enter radius");
            radius = Convert.ToInt32(Console.ReadLine());   

            //business logic
            diameter = 2 * radius;
            circumference = diameter * Math.PI;
            area = Math.PI * (radius * radius);

            Console.WriteLine("Diameter is " + diameter);
            Console.WriteLine("Circumference is " + circumference);
            Console.WriteLine("Area is " + area);
        }//end main
    }//end class
}//end namespace