/*
 
* AHMET 'ZootHii' YILDIRIM

*/

using System;

namespace GameVectors
{

    public class Vector
    {
        // auto implemented property
        /*public float X { get; set; }
        public float Y { get; set; }
        public Vector(){}
        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }*/
        
        // idk this is more familiar
        private double x;
        private double y;
        
        public Vector(){}
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public double Length()
        {
            double length = Math.Sqrt(x * x + y * y);
            return length;
        }
        
        public double LengthSqr()
        {
            double length = x * x + y * y;
            return length;
        }

        public Vector Normalized()
        {
            var normalized = new Vector {x = x / Length(), y = y / Length()};
            return normalized;
        }
        
        //operator overloading
        public static Vector operator* (Vector vector, double scale)
        {
            var scaled = new Vector {x = vector.x * scale, y = vector.y * scale};
            return scaled;
        }
        
        //operator overloading
        public static Vector operator- (Vector vector1, Vector vector2)
        {
            /*var rVector = new Vector {x = vector1.x - vector2.x, y = vector2.y - vector2.y};
            return rVector;*/
            
            return new Vector {x = vector1.x - vector2.x, y = vector1.y - vector2.y};
        }
        
        //operator overloading
        public static Vector operator+ (Vector vector1, Vector vector2)
        {
            /*var rVector = new Vector {x = vector1.x + vector2.x, y = vector2.y + vector2.y};
            return rVector;*/
            
            return new Vector {x = vector1.x + vector2.x, y = vector1.y + vector2.y};
        }

        public static double DotProduct(Vector a, Vector b)
        {
            return (a.x * b.x) + (a.y * b.y); // dot product formula
        }
        
    }
    
    

    public class Point
    {
        private double x, y; 
        public Point() {}
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get => x;
            set => x = value;
        } 

        public double Y
        {
            get => y;
            set => y = value;
        }

        public Point AddVector(Vector v)
        {
            var p2 = new Point {x = x + v.X, y = y + v.Y};
            return p2;
        }
        
        //operator overloading
        public static Vector operator- (Point a, Point b)
        {
            var v = new Vector {X = a.x - b.x, Y = a.y - b.y};
            return v;
        }
    }
    
    
    internal static class Vectors
    {
        
        public static void Main(string[] args)
        {
            
            var i = new Point(3,4);
            var p = new Point(1,2);
            var v = new Vector(3,4);
            var pi = (i - p); // using operator overloading we can do point - point 
            var normalized = pi.Normalized();
            var scaled = v * 2;
            var added = pi - v;
            var added2 = pi + v;

            //NORMALIZE
            Console.WriteLine("NORMALIZE");
            Console.WriteLine("=========");
            Console.WriteLine("not normalized [pi]");
            Console.WriteLine("(" + pi.X + "," + pi.Y + ")");
            Console.WriteLine("Length: " + pi.Length());
            Console.WriteLine("=========");
            Console.WriteLine("normalized [pi]");
            Console.WriteLine("(" + normalized.X + "," + normalized.Y + ")");
            Console.WriteLine("Length: " + normalized.Length());
            //SCALING
            Console.WriteLine("SCALING");
            Console.WriteLine("=========");
            Console.WriteLine("scaled by * 2 [v]");
            Console.WriteLine("(" + v.X  + "," + v.Y + ")");
            Console.WriteLine("(" + scaled.X  + "," + scaled.Y + ")");
            Console.WriteLine("Length: " + v.Length());
            Console.WriteLine("Length: " + scaled.Length());
            Console.WriteLine("=========");
            //ADDING
            Console.WriteLine("ADDING");
            Console.WriteLine("=========");
            Console.WriteLine("PI: " + "(" + pi.X  + "," + pi.Y + ")");
            Console.WriteLine("V: " + "(" + v.X  + "," + v.Y + ")");
            Console.WriteLine("Added1: " + "(" + added.X  + "," + added.Y + ")");
            Console.WriteLine("Length Added1: " + added.Length());
            Console.WriteLine("Added2: " + "(" + added2.X  + "," + added2.Y + ")");
            Console.WriteLine("Length Added2: " + added2.Length());

        }
    }
}