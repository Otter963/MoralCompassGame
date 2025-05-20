using UnityEngine;
using UnityEngine.InputSystem;

/*Reference:
Title:  How to Talk to NPCs! (or Interact with any Object, Open Doors, Push Buttons, Unity Tutorial) 
Author: Code Monkey
Date: 2022, October 12
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=LdoImzaY6M4
*/

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            IInteractable interactable = GetInteractableObject();
            if (interactable != null)
            {
                interactable.Interact(transform);
            }
        }
    }

    public IInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteractable interactable))
            {
                return interactable;
            }
            
        }
        return null;
    }
}
