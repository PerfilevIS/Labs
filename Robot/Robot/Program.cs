using RobotClass;

namespace RobotMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot("Робот 1", 200, 199);
            Robot robot2 = new Robot("Робот 2", 200, 199);

            for (int i = 0; i < 5; i++)
            {
                robot1.Move();
                robot2.Move();
                Console.WriteLine(robot1.GetInfo());
                Console.WriteLine(robot2.GetInfo());
                Console.WriteLine("");
                Thread.Sleep(2000);
            }
        }
    }
}