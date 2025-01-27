using Ass5OOP.Classes;
using Ass5OOP.Interfaces;
using static Ass5OOP.Program;

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

        #region Second Project
        //public static class Math
        //{
        //    public static double Add(double num1, double num2)
        //    {
        //        return num1 + num2;
        //    }

        //    public static double Subtract(double num1, double num2)
        //    {
        //        return num1 - num2;
        //    }

        //    public static double Multiply(double num1, double num2)
        //    {
        //        return num1 * num2;
        //    }

        //    public static double Divide(double num1, double num2)
        //    {
        //        if (num2 == 0)
        //        {
        //            Console.WriteLine("can't divide by zero");
        //        }
        //        return num1 / num2;
        //    }
        //}
        #endregion

        #region Third Project

        #region Part01
        public abstract class Discount
        {
            public string Name { get; protected set; }

            protected Discount(string name)
            {
                Name = name;
            }

            public abstract decimal CalculateDiscount(decimal price, int quantity);
        }
        #endregion

        #region Part02
        public class PercentageDiscount : Discount
        {
            private decimal _percentageOff;

            public PercentageDiscount(decimal percentageOff) : base("Percentage Discount")
            {
                if (percentageOff < 0 || percentageOff > 100)
                    Console.WriteLine("Percentage must be between 0 and 100");

                _percentageOff = percentageOff;
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                return price * quantity * (_percentageOff / 100);
            }
        }

        public class FlatDiscount : Discount
        {
            private decimal _flatAmount;

            public FlatDiscount(decimal flatAmount) : base("Flat Discount")
            {
                if (flatAmount < 0)
                    Console.WriteLine("Flat amount cannot be negative");

                _flatAmount = flatAmount;
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                return _flatAmount * Math.Min(quantity, 1);
            }
        }

        public class BuyOneGetOneDiscount : Discount
        {
            public BuyOneGetOneDiscount() : base("Buy One Get One Discount")
            {
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                if (quantity <= 1)
                    return 0;

                return (price / 2) * (quantity / 2);
            }
        }

        public class NoDiscount : Discount
        {
            public NoDiscount() : base("No Discount")
            {
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                return 0;
            }
        }
        #endregion

        #region Part03
        public abstract class User
        {
            public string Name { get; protected set; }

            protected User(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Name cannot be empty");

                Name = name;
            }

            public abstract Discount GetDiscount();
        }

        public class RegularUser : User
        {
            public RegularUser(string name) : base(name)
            {
            }

            public override Discount GetDiscount()
            {
                return new PercentageDiscount(5); 
            }
        }

        public class PremiumUser : User
        {
            public PremiumUser(string name) : base(name)
            {
            }

            public override Discount GetDiscount()
            {
                return new FlatDiscount(100);
            }
        }

        public class GuestUser : User
        {
            public GuestUser(string name) : base(name)
            {
            }

            public override Discount GetDiscount()
            {
                return new NoDiscount(); 
            }
        }
        #endregion

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


            #region Second Project
            //double a = 10;
            //double b = 22;

            //Console.WriteLine($"Addition: {a} + {b} = {Math.Add(a, b)}");
            //Console.WriteLine($"Subtraction: {a} - {b} = {Math.Subtract(a, b)}");
            //Console.WriteLine($"Multiplication: {a} × {b} = {Math.Multiply(a, b)}");
            //Console.WriteLine($"Division: {a} ÷ {b} = {Math.Divide(a, b)}");            
            #endregion


            #region Third Project

            #region Part04
            try
            {
                while (true)
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("\nSelect your user type:");
                    Console.WriteLine("1. Regular User (5% discount)");
                    Console.WriteLine("2. Premium User ($100 flat discount)");
                    Console.WriteLine("3. Guest User (no discount)");
                    Console.Write("Enter choice (1-3): ");

                    User user = CreateUser(name);
                    if (user == null) continue;

                    Console.Write("\nEnter product price: $");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price <= 0)
                    {
                        Console.WriteLine("Invalid price Please enter a positive number.");
                        continue;
                    }

                    Console.Write("Enter quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
                    {
                        Console.WriteLine("Invalid quantity Please enter a positive number.");
                        continue;
                    }

                    Discount discount = user.GetDiscount();
                    decimal totalPrice = price * quantity;
                    decimal discountAmount = discount.CalculateDiscount(price, quantity);
                    decimal finalPrice = totalPrice - discountAmount;

                    Console.WriteLine($"Customer: {user.Name}");
                    Console.WriteLine($"Discount Type: {discount.Name}");
                    Console.WriteLine($"Product Price: ${price}");
                    Console.WriteLine($"Quantity: {quantity}");
                    Console.WriteLine($"Total Before Discount: ${totalPrice}");
                    Console.WriteLine($"Discount Amount: ${discountAmount}");
                    Console.WriteLine($"Final Price: ${finalPrice}");

                    Console.Write("\nWould you like to continue (y/n): ");
                    if (Console.ReadLine()?.ToLower() != "y")
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static User CreateUser(string name)
        {
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice Please enter number between 1 and 3");
                return null;
            }

            return choice switch
            {
                1 => new RegularUser(name),
                2 => new PremiumUser(name),
                3 => new GuestUser(name),
                _ => null
            };
        }
        #endregion

        #endregion



    }
}
