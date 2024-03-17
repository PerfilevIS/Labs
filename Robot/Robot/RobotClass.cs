using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClass

{
    public class Robot
    {
        public string Name { get; private set; }
        public Tuple<int, int> Position { get; private set; }

        private Thread moveThread;

        private string directions2 = "";

        public Robot(string name, int x, int y)
        {
            Name = name;
            Position = Tuple.Create(x, y);
            moveThread = new Thread(Move);
        }

        public void StartMoving()
        {
            moveThread.Start();
        }

        public void Move()
        {
            Random random = new Random();
            int direction = random.Next(4);

            switch (direction)
            {
                case 0:
                    Position = Tuple.Create(Position.Item1, Position.Item2 + 1);
                    directions2 = "вперед";
                    break;
                case 1:
                    Position = Tuple.Create(Position.Item1, Position.Item2 - 1);
                    directions2 = "назад";
                    break;
                case 2:
                    Position = Tuple.Create(Position.Item1 - 1, Position.Item2);
                    directions2 = "влево";
                    break;
                case 3:
                    Position = Tuple.Create(Position.Item1 + 1, Position.Item2);
                    directions2 = "вправо";
                    break;
            }
            Thread.Sleep(1000);
        }

        public string GetInfo()
        {

            return $"{Name} {directions2} ({Position.Item1}, {Position.Item2})";
        }
    }
}