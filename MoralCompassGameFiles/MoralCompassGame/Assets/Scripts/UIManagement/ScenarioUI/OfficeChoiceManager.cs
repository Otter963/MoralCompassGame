using System.Runtime.InteropServices;
using UnityEngine;

//this is the format for the different scenario choice managers

public class OfficeChoiceManager : MonoBehaviour
{
    [Header("Compass Sprites")]
    [SerializeField] private GameObject defaultCompassSprite;
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;

    [Header("Player Stuff")]
    [SerializeField] private GameObject officeScenarioCanvas;
    [SerializeField] private GameObject playerCanvas;
    [SerializeField] private GameObject interactCanvas;
    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private OfficeScenarioInteractable officeScenarioInteractable;
    //to disable so player can't redo their choice
    [SerializeField] private GameObject officeScenarioInteractBox;

    [Header("Doors")]
    [SerializeField] private GameObject badChoiceDoor;
    [SerializeField] private GameObject middleChoiceDoor;
    [SerializeField] private GameObject goodChoiceDoor;

    //bad choice
    public void ChoiceOne()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(true);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);

        officeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        officeScenarioInteractable.officeScenarioActive = false;
        officeScenarioInteractBox.SetActive(false);

        badChoiceDoor.SetActive(false);
    }

    //middle choice
    public void ChoiceTwo()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(true);
        goodCompassSprite.SetActive(false);

        officeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        officeScenarioInteractable.officeScenarioActive = false;
        officeScenarioInteractBox.SetActive(false);

        middleChoiceDoor.SetActive(false);
    }

    //good choice
    public void ChoiceThree()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(true);

        officeScenarioCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        interactCanvas.SetActive(true);
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        officeScenarioInteractable.officeScenarioActive = false;
        officeScenarioInteractBox.SetActive(false);

        goodChoiceDoor.SetActive(false);
    }
}
