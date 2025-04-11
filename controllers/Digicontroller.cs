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
        Console.WriteLine("velg Digimon id:");
        int answear = Convert.ToInt32(Console.ReadLine());

var result = _dataset.DigiMons.Where(s => s.Number == answear);

        foreach (var digi in result)
        {
            Console.WriteLine($"{digi.Digimon}");
        }
    }


}