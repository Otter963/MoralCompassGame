using UnityEngine;

public class CoffeeScenarioInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject coffeeScenarioCanvas;
    [SerializeField] private GameObject playerCanvas;
    [SerializeField] private GameObject interactCanvas;
    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private GameObject defaultCompassSprite;
    public bool coffeeScenarioActive;

    public void StartOfficeScenario()
    {
        Debug.Log("Starting office scenario");
        defaultCompassSprite.SetActive(true);
        coffeeScenarioActive = true;
        coffeeScenarioCanvas.SetActive(true);
        playerCanvas.SetActive(false);
        interactCanvas.SetActive(false);
        playerMovement.enabled = false;
        playerCamera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public string GetInteractText()
    {
        return "Start Office Scenario";
    }

    public void Interact(Transform interactorTransform)
    {
        FindFirstObjectByType<AudioManager>().Play("CoffeeScenario");
        StartOfficeScenario();
    }
}
