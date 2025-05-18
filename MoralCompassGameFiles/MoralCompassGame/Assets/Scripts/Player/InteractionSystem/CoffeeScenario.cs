using UnityEngine;

public class CoffeeScenario : MonoBehaviour
{
    [SerializeField] private string prompt;
    public bool isCoffeeScenarioActive = false;
    [SerializeField] private GameObject playerDefaultCompassSprite;

    //public string InteractionPrompt { get => prompt; }
    public string InteractionPrompt => prompt;
    public bool Interact(Interactor interactor)
    {
        //Below is where logic can be put with WHAT you want the object to do. For example, with a chest to display the inventory menu
        isCoffeeScenarioActive = true;
        playerDefaultCompassSprite.SetActive(true);
        Debug.Log("Beginning Coffee Scenario");
        return true;
    }
}
