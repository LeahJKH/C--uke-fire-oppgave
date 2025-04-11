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
        }
        
    }
}