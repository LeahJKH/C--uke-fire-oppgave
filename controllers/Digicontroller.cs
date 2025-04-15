using System;
using System.Linq;

public class Controller
{
    private DigiDataset _dataset;
    public Controller(DigiDataset dataset)
    {
        _dataset = dataset;
    }

    public void Run()
    {
        Console.WriteLine("what do you want too search for?\n1.Name\n2.id");
        var searchquery = Console.ReadLine();
        switch (searchquery)
        {
            case "1":
                SearchName();
                break;
            case "2":
                searchID();
                break;
            default:
                Console.WriteLine("use the numbers that was shown");
                break;
        }
        void SearchName() 
        {
           Console.Write("velg Digimon name: ");
        string? answear = Console.ReadLine();
        var result = _dataset.DigiMons.Where(s => s.Digimon  == answear); 
         foreach (var digi in result)
        {
            Console.WriteLine($"Here is your digimon:\nName of digimon: {digi.Digimon}.\nType: {digi.Type}.\nAttribute: {digi.attribute}\nStage: {digi.Stage}\n");
        }
        }
        void searchID () 
        {
        Console.Write("velg Digimon id: ");
        int answear = Convert.ToInt32(Console.ReadLine());
        var result = _dataset.DigiMons.Where(s => s.Number == answear);
         foreach (var digi in result)
        {
            Console.WriteLine($"\nName of digimon: {digi.Digimon}.\nType: {digi.Type}.\nAttribute: {digi.attribute}");
        }
        }

       
    }


}