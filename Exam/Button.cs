namespace Exam
{
    public class Button
    {
        public string Name { get; set; }
        private int ButtonLenght { get; set; }
        private int ButtonWidth { get; set; }
        private int NuberOfClicks { get; set; }
        public Button() {}

        public Button(string name, int lenght, int width)
        {
            Name = name;
            ButtonLenght = lenght;
            ButtonWidth = width;
            NuberOfClicks = 0;
        }

        public void Push()
        {
            System.Console.WriteLine($"Button \"{Name}\" was pushed");
            NuberOfClicks++;
        }

        public int GetNumberOfClicks()
        {
            return NuberOfClicks;
        }
    }
}