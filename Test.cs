using System;


namespace Ncit_lab_asal1
{
 
    class Box
    {
        public static int count;
        double length, breadth, height;

        public Box()
        {
            length = 5.5;
            breadth = 4.6;
            height = 3.6;
            count++;
        }

        public Box(Double length, double breadth, double height)
        {
            this.length = length;   
            this.breadth = breadth; 
            this.height = height;
            count++;
        }
        public void SetDimension(double l, double b, double h)
        {
            length = l;
            height = h;
            breadth = b;
            count++;
        }
        public void Display()
        {
            Console.WriteLine("Length = "+length +" Breadth= "+breadth+"height="+height );
        }
        public static void ShowCount()
        {
            Console.WriteLine("No. of objects created =" + count);
        }
    }
   
     class Test
    {
        static void Main(string[] args)
        {
            Box.ShowCount();
            //Box box1;
            Box box1= new Box();
            Box box2 = new Box(34.5, 6.9, 7.8);
            box1.Display();
            box1.SetDimension(33.5, 22.5, 33.2);
            box2.Display();
            Box.ShowCount();
        }
    }
    
}
