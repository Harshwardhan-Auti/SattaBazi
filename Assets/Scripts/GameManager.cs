using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("Money")]
    [SerializeField] private int totalMoney = 1000;
    public int playerMoney => totalMoney;

    [Header("Player Items ")]
    [SerializeField] private List<CrateResults> playerItems = new List<CrateResults>();
    public IReadOnlyList<CrateResults> itemsWon => playerItems;

    [Header("GameState")]
    public OpenInventory openInventoryScript;
    

   


    public void CratePurchased(int crateValue)
    {
        
        totalMoney -= crateValue;
    
    
    }

    public void GainedItems(CrateResults result)
    {

        playerItems.Add(result);   
    
    
    }
    
}
