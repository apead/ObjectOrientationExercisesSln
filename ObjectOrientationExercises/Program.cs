namespace ObjectOrientationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];

            shapes[0] = new Square(50);
            shapes[1] = new Circle(10);
            shapes[2] = new Triangle(10, 20);
            shapes[3] = new Rectangle(100,200);

            for(int i = 0; i < shapes.Length;i++ )
            {
                Shape shape = shapes[i];
                Console.WriteLine(shape.GetShapeName() + " " + shape.GetArea());
            }            
        }
    }
}
