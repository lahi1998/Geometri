using Geomentri;


internal class Program
{
    private static void Main(string[] args)
    {
        // square tests
        #region
        Square square1 = new Square(10);
        Square square2 = new Square(15);
        Square square3 = new Square(6);
        Square square4 = new Square(500);

        double sq1 = square1.Perimeter();
        double sq2 = square2.Perimeter();
        double sq3 = square3.Perimeter();
        double sq4 = square4.Perimeter();

        double sqa1 = square1.Area();
        double sqa2 = square2.Area();
        double sqa3 = square3.Area();
        double sqa4 = square4.Area();

        Console.WriteLine();
        Console.WriteLine(" Squares ");
        Console.WriteLine();
        Console.WriteLine(" omkreds = {0}", sq1);
        Console.WriteLine(" areal = {0}", sqa1);
        Console.WriteLine(" omkreds = {0}", sq2);
        Console.WriteLine(" areal = {0}", sqa2);
        Console.WriteLine(" omkreds = {0}", sq3);
        Console.WriteLine(" areal = {0}", sqa3);
        Console.WriteLine(" omkreds = {0}", sq4);
        Console.WriteLine(" areal = {0}", sqa4);
        #endregion

        // Rectangle tests
        #region
        Rectangle retangle1 = new Rectangle(10, 20);
        Rectangle retangle2 = new Rectangle(15, 30);
        Rectangle retangle3 = new Rectangle(6, 14);
        Rectangle retangle4 = new Rectangle(500, 700);

        double r1 = retangle1.Perimeter();
        double r2 = retangle2.Perimeter();
        double r3 = retangle3.Perimeter();
        double r4 = retangle4.Perimeter();

        double ra1 = retangle1.Area();
        double ra2 = retangle2.Area();
        double ra3 = retangle3.Area();
        double ra4 = retangle4.Area();

        Console.WriteLine();
        Console.WriteLine(" Rectangles ");
        Console.WriteLine();
        Console.WriteLine(" omkreds = {0}", r1);
        Console.WriteLine(" areal = {0}", ra1);
        Console.WriteLine(" omkreds = {0}", r2);
        Console.WriteLine(" areal = {0}", ra2);
        Console.WriteLine(" omkreds = {0}", r3);
        Console.WriteLine(" areal = {0}", ra3);
        Console.WriteLine(" omkreds = {0}", r4);
        Console.WriteLine(" areal = {0}", ra4);
        #endregion


        // Parallelogram tests
        #region
        Parallelogram Parallelogram1 = new Parallelogram(10, 20, 15);
        Parallelogram Parallelogram2 = new Parallelogram(15, 30, 5);
        Parallelogram Parallelogram3 = new Parallelogram(6, 14, 9);
        Parallelogram Parallelogram4 = new Parallelogram(500, 700, 100);

        double p1 = retangle1.Perimeter();
        double p2 = retangle2.Perimeter();
        double p3 = retangle3.Perimeter();
        double p4 = retangle4.Perimeter();

        double pa1 = retangle1.Area();
        double pa2 = retangle2.Area();
        double pa3 = retangle3.Area();
        double pa4 = retangle4.Area();

        Console.WriteLine();
        Console.WriteLine(" Parallelograms ");
        Console.WriteLine();
        Console.WriteLine(" omkreds = {0}", p1);
        Console.WriteLine(" areal = {0}", pa1);
        Console.WriteLine(" omkreds = {0}", p2);
        Console.WriteLine(" areal = {0}", pa2);
        Console.WriteLine(" omkreds = {0}", p3);
        Console.WriteLine(" areal = {0}", pa3);
        Console.WriteLine(" omkreds = {0}", p4);
        Console.WriteLine(" areal = {0}", pa4);
        #endregion

        // Trapeze tests
        #region
        Trapeze trapeze1 = new Trapeze(10, 20, 10, 25);
        Trapeze trapeze2 = new Trapeze(15, 30, 20, 40);
        Trapeze trapeze3 = new Trapeze(6, 14, 12, 26);
        Trapeze trapeze4 = new Trapeze(500, 700, 400, 25);

        double t1 = trapeze1.Perimeter();
        double t2 = trapeze2.Perimeter();
        double t3 = trapeze3.Perimeter();
        double t4 = trapeze4.Perimeter();

        double ta1 = trapeze1.Area();
        double ta2 = trapeze2.Area();
        double ta3 = trapeze3.Area();
        double ta4 = trapeze4.Area();

        Console.WriteLine();
        Console.WriteLine(" Trapezes ");
        Console.WriteLine();
        Console.WriteLine(" omkreds = {0}", t1);
        Console.WriteLine(" areal = {0}", ta1);
        Console.WriteLine(" omkreds = {0}", t2);
        Console.WriteLine(" areal = {0}", ta2);
        Console.WriteLine(" omkreds = {0}", t3);
        Console.WriteLine(" areal = {0}", ta3);
        Console.WriteLine(" omkreds = {0}", t4);
        Console.WriteLine(" areal = {0}", ta4);
        #endregion

        // Right_angle_triangle tests
        #region
        Right_angled_triangle triangle1 = new Right_angled_triangle(10, 10);
        Right_angled_triangle triangle2 = new Right_angled_triangle(15, 15);
        Right_angled_triangle triangle3 = new Right_angled_triangle(6, 6);
        Right_angled_triangle triangle4 = new Right_angled_triangle(16, 16);

        double tr1 = triangle1.Perimeter();
        double tr2 = triangle1.Perimeter();
        double tr3 = triangle1.Perimeter();
        double tr4 = triangle1.Perimeter();

        double tra1 = triangle1.Area();
        double tra2 = triangle1.Area();
        double tra3 = triangle1.Area();
        double tra4 = triangle1.Area();

        Console.WriteLine();
        Console.WriteLine(" Rectangles ");
        Console.WriteLine();
        Console.WriteLine(" omkreds = {0}", tr1);
        Console.WriteLine(" areal = {0}", tra1);
        Console.WriteLine(" omkreds = {0}", tr2);
        Console.WriteLine(" areal = {0}", tra2);
        Console.WriteLine(" omkreds = {0}", tr3);
        Console.WriteLine(" areal = {0}", tra3);
        Console.WriteLine(" omkreds = {0}", tr4);
        Console.WriteLine(" areal = {0}", tra4);
        #endregion

        Console.Read();
    }
}