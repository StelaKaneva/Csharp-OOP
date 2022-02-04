using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Snake();
            Snake snake = animal as Snake;
            snake.EatHuman();

            if (animal is Snake)
            {
                Console.WriteLine("Zmiya");
            }
            else
            {
                Console.WriteLine("Cat");
            }

            Animal animal2 = new Cat();

            Human catLover = new Human(animal2);
            Human snakeHater = new Human(animal);

            while (true)
            {
                Console.ReadLine();
                catLover.Feed();
                catLover.PutToSleep();
                snakeHater.Feed();
                snakeHater.PutToSleep();
            }
        }
    }
}
