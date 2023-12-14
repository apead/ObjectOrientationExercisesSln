using ObjectOrientationExercises.Inheritance;

namespace ObjectOrientationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Abstraction Start
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

            //  Abstraction End


            //  Inheritance Start

            Person bob = new Person("Bob", 40, "Male", "423432324423");
            Console.WriteLine(bob.GetName());
           
            Student samantha = new Student("Samantha",21,"Female","234234234","12345","Computer Science");
            Console.WriteLine(samantha.GetName());
            Console.WriteLine( samantha.CanQualifyForCourse());
        
            //  Inheritance End
        }
    }
}
