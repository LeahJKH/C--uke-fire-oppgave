namespace C__uke_fire_oppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var digimons = CsvReader.ReadDigis();
            var digiDataSet = new DigiDataset {DigiMons = digimons};

            var controller = new Controller(digiDataSet);
            controller.Run();

            Runnify();
            void Runnify () 
            {
                Console.WriteLine("do you wish too check another? y/n");
                string? yorn = Console.ReadLine();
                switch(yorn?.ToLower())
                {
                    case "y": 
                        controller.Run();
                        Runnify();
                        break;
                    case "n":
                        Console.WriteLine("thank you for using :3");
                        break;
                    default: 
                        Runnify();
                        break;
                }
            }

        }
        
    }
}