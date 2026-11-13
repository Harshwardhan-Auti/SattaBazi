using UnityEngine;
using System.Collections.Generic;



[System.Serializable]
public class Item 
{
    [SerializeField] public string itemName;

        
    
}

[System.Serializable]
public class RarityEntry 
{

    [SerializeField] public string rarityName;
    [SerializeField] public List<Item> items;
    [SerializeField] public int weight;





}

[CreateAssetMenu]
public class CrateDefination : ScriptableObject
{

    [SerializeField] public List<RarityEntry> rarities;
    [SerializeField] public int crateValue;

}
