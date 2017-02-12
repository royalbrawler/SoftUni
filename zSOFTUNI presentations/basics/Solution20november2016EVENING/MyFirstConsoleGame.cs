using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 40;
            Console.WindowHeight = 21;
            Console.BufferWidth = 40;
            Console.BufferHeight = 21;
            Console.CursorVisible = false;

            var playerX = 39 / 2 - 1;
            var playerY = 19;
            var playerIcon = "^";

            var projectileX = 0;
            var projectileY = 0;
            var projectileVisible = false;
            var projectileIcon = "|";

            Random random = new Random();

            var enemyIcon = "*";
            var firstEnemyX = random.Next(39);
            var firstEnemyY = random.Next(10);
            var isFirstDestroyed = false;

            var secondEnemyX = random.Next(39);
            var secondEnemyY = random.Next(10);
            var isSecondDestroyed = false;

            var thirdEnemyX = random.Next(39);
            var thirdEnemyY = random.Next(10);
            var isThirdDestroyed = false;

            var score = 0;

            while(true)
            {
                while(true)
                {
                    if(Console.KeyAvailable)
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey();

                        switch(pressedKey.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                if(playerX - 1 >= 0)
                                {
                                    playerX = playerX - 1;
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                if(playerX + 1 < 40)
                                {
                                    playerX = playerX + 1;
                                }
                                break;
                            case ConsoleKey.Spacebar:
                                projectileX = playerX;
                                projectileY = playerY - 1;
                                projectileVisible = true;
                                break;
                        }
                    }

                    if (projectileVisible)
                    {
                        Console.SetCursorPosition(projectileX , projectileY);
                        Console.Write(projectileIcon);

                        if (projectileY > 0)
                        {
                            projectileY--;

                        }
                        else
                        {
                            projectileVisible = false;
                        }

                    }
                    if(!isFirstDestroyed)
                    {
                        Console.SetCursorPosition(firstEnemyX , firstEnemyY);
                        Console.Write(enemyIcon);

                        if (projectileX == firstEnemyX && projectileY == firstEnemyY)
                        {
                            isFirstDestroyed = true;
                            projectileVisible = false;
                            score += 50;
                        }
                    }
                    if(!isSecondDestroyed)
                    {
                        Console.SetCursorPosition(secondEnemyX , secondEnemyY);
                        Console.Write(enemyIcon);

                        if(projectileX == secondEnemyX && projectileY == secondEnemyY)
                        {
                            isSecondDestroyed = true;
                            projectileVisible = false;
                            score += 50;
                        }
                    }
                    if(!isThirdDestroyed)
                    {
                        Console.SetCursorPosition(thirdEnemyX , thirdEnemyY);
                        Console.Write(enemyIcon);

                        if(projectileX == thirdEnemyX && projectileY == thirdEnemyY)
                        {
                            isThirdDestroyed = true;
                            projectileVisible = false;
                            score += 50;
                        }
                    }

                    if (isThirdDestroyed && isFirstDestroyed && isSecondDestroyed)
                    {
                        break;
                    }
                    Console.SetCursorPosition(playerX, playerY);
                    Console.Write(playerIcon);
                    Console.SetCursorPosition(0, playerY + 1);
                    Console.Write("Score: {0}", score);
                    Thread.Sleep(100);
                    Console.Clear();
                }
                Console.SetCursorPosition(Console.WindowWidth/2 - 6, Console.WindowHeight/2);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Game Over!!!");
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
