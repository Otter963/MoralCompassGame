using UnityEngine;

public class CoffeeChoiceManager : MonoBehaviour
{
    [Header("Compass Sprites")]
    [SerializeField] private GameObject defaultCompassSprite;
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;

    [Header("Player Stuff")]
    [SerializeField] private GameObject coffeeScenarioCanvas;
    [SerializeField] private GameObject playerCanvas;
    [SerializeField] private GameObject interactCanvas;
    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private CoffeeScenarioInteractable coffeeScenarioInteractable;
    //to disable so player can't redo their choice
    [SerializeField] private GameObject coffeeScenarioInteractBox;

    //bad choice
    public void ChoiceOne()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(true);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);

        coffeeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        coffeeScenarioInteractable.coffeeScenarioActive = false;
        coffeeScenarioInteractBox.SetActive(false);
    }

    //good choice
    public void ChoiceTwo()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(true);

        coffeeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        coffeeScenarioInteractable.coffeeScenarioActive = false;
        coffeeScenarioInteractBox.SetActive(false);
    }

    //middle choice
    public void ChoiceThree()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(true);
        goodCompassSprite.SetActive(false);

        coffeeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        coffeeScenarioInteractable.coffeeScenarioActive = false;
        coffeeScenarioInteractBox.SetActive(false);
    }
}
