using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

/*Reference:
Title: Unity Interaction Tutorial | How To Interact With Any Game Object (Open Chests & Doors etc) 
Author: Dan Pos
Date: 2022, April 3
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=THmW4YolDok
*/

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask interactableMask;

    //getting the office scenario script reference
    [SerializeField] private OfficeScenario officeScenario;

    //getting the office scenario manager script reference to change text corresponding to choice
    [SerializeField] private OfficeScenarioManager officeScenarioManager;

    //getting the player as a game object
    [SerializeField] private PlayerMovement playerMovement;

    //getting the player camera script
    [SerializeField] private PlayerCamera playerCamera;

    [Header("Office Scenario")]

    //the office scenario canvas
    [SerializeField] private GameObject officeScenarioCanvas;

    //getting the interact text game object via the canvas in the game
    [SerializeField] private GameObject interactText;

    private readonly Collider[] colliders = new Collider[3];
    //storing number of colliders found from the layermask
    [SerializeField] private int numFound;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders, interactableMask);

        if (officeScenario.isOfficeScenarioActive == false)
        {
            officeScenarioCanvas.SetActive(false);
            interactText.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerCamera.enabled = true;
            playerMovement.enabled = true;
        }

        //if we've found objects to interact with
        if (numFound > 0)
        {
            //will get any monobehaviour script that is also implementing the interface below i.e the Chest.cs script

            //setting the interact text game object to active when within range of an interactable
            interactText.SetActive(true);

            var interactable = colliders[0].GetComponent<IInteractorInterface>();

            //using the new input system below
            if (interactable != null && Keyboard.current.eKey.wasPressedThisFrame)
            {
                interactable.Interact(this);

                //the below is for the office scenario and can be implemented for every other scenario once added for ME2

                //getting the office scenario bool if it's true to make sure the player script gets set to inactive so player cannot move during dialogue
                if (officeScenario.isOfficeScenarioActive == true)
                {
                    //for the CPA, this is just a canvas being set to true for now with buttons which will do specific things
                    officeScenarioCanvas.SetActive(true);
                    interactText.SetActive(false);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    playerCamera.enabled = false;
                    playerMovement.enabled = false;
                }
                //where else if statement would go

            }
        }//the below will be if the player is no longer in the radius of an interactable
        else
        {
            interactText.SetActive(false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }
}
