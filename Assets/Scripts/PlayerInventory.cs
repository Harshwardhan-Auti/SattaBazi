using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public GameManager gameManagerScript;

    [Header("Inventory Panel")]
    public GameObject slot;
    public Transform content;

  

    public void OnEnable()
    {
        foreach (Transform child in content)
        {

            Destroy(child.gameObject);
            
            
        }


        foreach( CrateResults won in gameManagerScript.itemsWon)
        {
            GameObject newSlot =  Instantiate(slot, content);
            TMP_Text label = newSlot.GetComponent<TMP_Text>();
            
            label.text = won.rarity +" - " + won.item.itemName;


        }
        
         
    }

}
