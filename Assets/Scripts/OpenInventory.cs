
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenInventory : MonoBehaviour
{

    public GameObject pannel;
    public CrateTester crateTesterScript;


    public void OnOpeningPanel(InputAction.CallbackContext context )
    {




        if (context.performed && !crateTesterScript.isPanelOpen)
        {

            bool isPannelOpen = pannel.activeSelf;
            isPannelOpen = !isPannelOpen;
            pannel.SetActive(isPannelOpen);

            if (isPannelOpen)
            {
                Time.timeScale = 0f;

            }
            else
            {
                Time.timeScale = 1f;

            }


        }








    }


}
