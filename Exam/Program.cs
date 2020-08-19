using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать тип, который представляет собой кнопку. 
            Учесть все свойства кнопки из реальных проектов. 
            Дать возможность при "нажатии" кнопки вызывать дополнительные действия 
            с любым количеством параметров на усмотрение пользователя. 

            Время начала 19-05. Время сдачи 21-00. Потом полчаса на вопросы.*/
            //List<Button> buttons = new List<Button>();
            Button button = new Button();
            button = CreateButton();

            App(button);
        }

        static Button CreateButton()
        {
            string buttonName;
            string buttonInput;
            bool parseResult;
            int buttonLenght;
            int buttonWidth;
            Console.Write("Enter button name: ");
            buttonName = Console.ReadLine();
            Console.Write("Enter button lenght: ");
            buttonInput = Console.ReadLine();
            parseResult = int.TryParse(buttonInput, out buttonLenght);
            Console.Write("Enter button width: ");
            buttonInput = Console.ReadLine();
            parseResult = int.TryParse(buttonInput, out buttonWidth);
            Button button = new Button(buttonName, buttonLenght, buttonWidth);
            return button;
        }

        static void App(Button button)
        {
            string input;
            int buttonOption = -1;
            bool buttonOptionResult;
            while (buttonOption != 2)
            {
                Console.Clear();
                Console.WriteLine("Choose option:");
                Console.WriteLine("1)Push button");
                Console.WriteLine("2)Exit");
                input = Console.ReadLine();
                buttonOptionResult = int.TryParse(input, out buttonOption);
                Console.Clear();
                switch (buttonOption)
                {
                    case 1:
                        {
                            button.Push();
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Good bye");
                            Console.WriteLine($"Button \"{button.Name}\" was pushed {button.GetNumberOfClicks()}");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You chose wrong option");
                            Console.WriteLine("Try again");
                            break;
                        }
                }
            }
        }
    }
}
