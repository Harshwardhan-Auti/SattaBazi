using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CrateTester : MonoBehaviour
{
    public CrateDefination crate;
    public TMP_Text resultText;
    public GameObject inventoryPannel;


    private bool isOpening = false;
    public bool isPanelOpen => isOpening;

    private CrateOpener opener = new CrateOpener();

    [Header("GameManger")]
    public GameManager gameManagerScript;







    public void OnOpening(InputAction.CallbackContext context)
    {

        if (context.performed && !isOpening && gameManagerScript.playerMoney >= crate.crateValue && !inventoryPannel.activeSelf)
        {
            StartCoroutine(OpenCrate());
           
            

        }
        else if (context.performed && gameManagerScript.playerMoney < crate.crateValue && !isOpening)
        {

            resultText.text = "You are broke mf ..go get some money ";

        }


    }

    private IEnumerator OpenCrate()
    {


        CrateResults result = opener.OpenCrate(crate);

        if (result == null)
        {


            yield break;
        }

        isOpening = true;
        gameManagerScript.CratePurchased(crate.crateValue);
        resultText.text = "Opening...";
        gameManagerScript.GainedItems(result);
        yield return new WaitForSeconds(2f);
        resultText.text = result.rarity + "\n" + result.item.itemName;
        isOpening = false;


    }


}