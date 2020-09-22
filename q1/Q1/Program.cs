using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class Shape{
        public abstract void Area();

    }
    public class Square:Shape
    {
        double a;
        double area;
        string ShapeName = "";

        public Square(double a)
        {
            ShapeName = "Square";
            this.a = a;
            Area();
        }

        public override void Area()
        {
            area = a * a;
        }
        public override string ToString()
        {
            return ("The Shape Name=" + this.ShapeName + "\nthe area = " +this.area.ToString());
        }
    }
    public class Circle:Shape
    {
        double radius;
        double area;
        string ShapeName = "";
        public Circle(double r)
        {
            ShapeName = "Circle";
            this.radius = r;
            Area();
        }

        public override void Area()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return ("The Shape Name=" + this.ShapeName + "\nthe area = " + this.area.ToString());
        }
    }

    public class Rectangle:Shape
    {
        
        double width;
        double height;
        double area = 0;
        string ShapeName = "";
        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;
            ShapeName = "Rectangle";
            Area();
        }

        public override void Area()
        {
            this.area = this.width * this.height;
        }

        public override string ToString()
        {
            return ("The Shape Name=" + this.ShapeName + "\nthe area = " + this.area.ToString());
        }
        

        
    }

    public class Triangle:Shape
    {
        double area = 0;
        string ShapeName = "";
        double tbase = 0;
        double theight = 0;
        public Triangle(double tbase, double theight)
        {
            this.tbase = tbase;
            this.theight = theight;
            this.ShapeName = "Triangle";
            Area();
        }

        public override void Area()
        {
            this.area = (0.5 * tbase * theight);
            
        }
        public override string ToString()
        {
            return ("The Shape Name=" + this.ShapeName + "\nthe area = " + this.area.ToString());
        }
    }
    
    class Program
    {
        public static int randomnumber(int min, int max)
        {
            Random r = new Random();
            return r.Next(min,max);
        }

        static void Main(string[] args)
        {
            int r;
            
            for (int i=0;i<=40;i++)
            {
                r = randomnumber(1,5);
                switch (r)
                {
                    case 1:
                        Square s = new Square(randomnumber(1,1000));
                        Console.WriteLine(i+" "+s.ToString());
                        break;
                    case 2:
                        Circle c = new Circle(randomnumber(1,1000));
                        Console.WriteLine(i+" " + c.ToString());
                        break;
                    case 3:
                        Triangle t = new Triangle(randomnumber(1,1000), randomnumber(1,1000));
                        Console.WriteLine(i+ " " + t.ToString());
                        break;
                    case 4:
                        Rectangle re = new Rectangle(randomnumber(1,1000), randomnumber(1,1000));
                        Console.WriteLine(i+ " " + re.ToString());
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
