using UnityEngine;

//this scenario can be used as a basis for the other scenarios

public class OfficeScenarioInteractable : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject officeScenarioCanvas;
    [SerializeField] private GameObject playerCanvas;
    [SerializeField] private GameObject interactCanvas;
    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerMovement playerMovement;
    public bool officeScenarioActive;

    public void StartOfficeScenario()
    {
        Debug.Log("Starting office scenario");
        officeScenarioActive = true;
        officeScenarioCanvas.SetActive(true);
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
        FindFirstObjectByType<AudioManager>().Play("OfficeScenario");
        StartOfficeScenario();
    }
}
