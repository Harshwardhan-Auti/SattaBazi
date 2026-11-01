
using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework.Constraints;
using UnityEngine;

public class CrateOpener 
{
    public CrateResults OpenCrate (CrateDefination crate)
    {
        int totalSum = 0;
        foreach (RarityEntry crateBox in crate.rarities )
        {

            totalSum = totalSum + crateBox.weight;
        
        
        }

        int rollValue = Random.Range(0, totalSum);

        int counter = 0;
        foreach (RarityEntry entry in crate.rarities)
        {
            counter = counter + entry.weight;

            if (rollValue < counter)
            {

                int itemIndex = Random.Range(0, entry.items.Count);
                CrateResults result = new CrateResults();
                result.rarity = entry.rarityName;
                result.item = entry.items[itemIndex];
                return result;
            }

            
        
        }

        return null;



    }
   
}
