using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OfficeScenario : MonoBehaviour, IInteractorInterface
{
    [SerializeField] private string prompt;
    public bool isOfficeScenarioActive = false;
    [SerializeField] private GameObject playerDefaultCompassSprite;
    [SerializeField] private GameObject interactUI;
    [SerializeField] private GameObject playerUICanvas;

    //public string InteractionPrompt { get => prompt; }
    public string InteractionPrompt => prompt;
    public bool Interact(Interactor interactor)
    {
        //Below is where logic can be put with WHAT you want the object to do. For example, with a chest to display the inventory menu
        isOfficeScenarioActive = true;
        playerDefaultCompassSprite.SetActive(true);
        interactUI.SetActive(false);
        playerUICanvas.SetActive(false);
        Debug.Log("Beginning Office Scenario");
        return true;
    }
}
