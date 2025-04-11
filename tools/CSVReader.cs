using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public static class CsvReader 
{
    public static List<DigiMon> ReadDigis()
    {
        var digis = new List<DigiMon>();
        var entries = File.ReadAllLines("./DigiDB_digimonlist.csv").Skip(1);
        foreach (var entry in entries)
        {
            var split = entry.Split(",");

            var digiM = new DigiMon
            {
                 Number = int.Parse(split[0]),
                Digimon = split[1],
                Stage = split[2],
                Type = split[3],
                attribute = split[4],
                Memory = int.Parse(split[5]),
                Equip_slots = int.Parse(split[6]),
                Lv_50_HP = int.Parse(split[7]),
                Lv_50_SP = int.Parse(split[8]),
                Lv_50_ATK = int.Parse(split[9]),
                Lv_50_Def = int.Parse(split[10]),
                Lv_50_Int = int.Parse(split[11]),
                Lv_50_Spd = int.Parse(split[12]),
            };
            digis.Add(digiM);
        }
        return digis;
    }
}