using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CrateTester : MonoBehaviour
{
    public CrateDefination crate;
    public TMP_Text resultText;

    private CrateOpener opener = new CrateOpener();

    void Update()
    {
        


    }


    public void OnOpening(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            CrateResults result = opener.OpenCrate(crate);
            resultText.text = result.rarity + "\n" + result.item.itemName;


        }



    }
}