using Ass5OOP.Classes;
using Ass5OOP.Interfaces;

namespace Ass5OOP
{
    internal class Program
    {
        #region First Project:
        //public class Point3D : ICloneable, IComparable<Point3D>
        //{
        //    public double X { get; set; }
        //    public double Y { get; set; }
        //    public double Z { get; set; }

        //    public Point3D() : this(0, 0, 0) { }

        //    public Point3D(double x) : this(x, 0, 0) { }

        //    public Point3D(double x, double y) : this(x, y, 0) { }

        //    public Point3D(double x, double y, double z)
        //    {
        //        X = x;
        //        Y = y;
        //        Z = z;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Point Coordinates: ({X}, {Y}, {Z})";
        //    }

        //    public static bool operator ==(Point3D p1, Point3D p2)
        //    {
        //        if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
        //            return true;
        //        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
        //            return false;
        //        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        //    }

        //    public static bool operator !=(Point3D p1, Point3D p2)
        //    {
        //        return !(p1 == p2);
        //    }

        //    public object Clone()
        //    {
        //        return new Point3D(X, Y, Z);
        //    }

        //    public int CompareTo(Point3D P)
        //    {
        //        if (P == null) return 1;

        //        int xComparison = X.CompareTo(P.X);
        //        if (xComparison != 0) return xComparison;

        //        return Y.CompareTo(P.Y);
        //    }
        //}
        #endregion



        static void Main(string[] args)
        {

            #region Question 01: Define an interface named IShape with a property Area and a method DisplayShapeInfo
            //ICircle circle = new Circle { Radius = 5};

            //IRectangle rectangle = new Rectangle { Length = 3 , Width = 4};

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 02 IAuthenticationService
            //IAuthenticationService authService = new BasicAuthenticationService();

            //if (authService.AuthenticateUser("admin", "pass1234"))
            //{
            //    Console.WriteLine("Login");

            //    if (authService.AuthorizeUser("admin", "Administrator"))
            //        Console.WriteLine("\nRole is right");

            //    else
            //        Console.WriteLine("Role is wrong");
            //}
            //else
            //{
            //    Console.WriteLine("Username or Password is wrong");
            //}
            #endregion

            #region Question 03 INotification
            //INotificationService EmailService = new EmailNotificationService();
            //INotificationService SMSService = new SmsNotificationService();
            //INotificationService PushService = new PushNotificationService();

            //EmailService.SendNotification("user@gmail.com", "hello,successful login");
            //SMSService.SendNotification("123-456", "This is SMS");
            //PushService.SendNotification("user", "hello user");

            #endregion

            //----------------------------------------------------------------------//
            #region First Project
            //try
            //{
            //Console.WriteLine("Enter coordinates for P1:");
            //string[] p1 = Console.ReadLine().Split();
            //Point3D P1 = new Point3D(
            //   double.Parse(p1[0]),
            //   double.Parse(p1[1]),
            //   double.Parse(p1[2])
            //);

            //Console.WriteLine("Enter coordinates for P2:");
            //string[] p2 = Console.ReadLine().Split();
            //Point3D P2 = new Point3D(
            //    double.Parse(p2[0]),
            //    double.Parse(p2[1]),
            //    double.Parse(p2[2])
            //);

            //    // Compare points
            //    Console.WriteLine($"P1: {P1}");
            //    Console.WriteLine($"P2: {P2}");
            //    Console.WriteLine($"P1 equals P2: {P1 == P2}");

            //    Point3D[] points = new Point3D[]
            //    {
            //    new Point3D(3, 2, 1),
            //    new Point3D(1, 2, 3),
            //    new Point3D(2, 1, 3)
            //    };

            //    Array.Sort(points);
            //    Console.WriteLine("\nSorted Points:");
            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point);
            //    }

            //    Point3D original = new Point3D(1, 2, 3);
            //    Point3D cloned = (Point3D)original.Clone();
            //    Console.WriteLine($"\nOriginal: {original}");
            //    Console.WriteLine($"Cloned: {cloned}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter numeric values");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Please enter three coordinates");
            //} 
            #endregion


        }
    }
}
