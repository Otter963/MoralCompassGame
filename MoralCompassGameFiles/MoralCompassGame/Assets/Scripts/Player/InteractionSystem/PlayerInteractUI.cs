using UnityEngine;
using TMPro;

/*Reference:
Title:  How to Talk to NPCs! (or Interact with any Object, Open Doors, Push Buttons, Unity Tutorial) 
Author: Code Monkey
Date: 2022, October 12
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=LdoImzaY6M4
*/

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;

    [SerializeField] private TextMeshProUGUI interactTextTextMeshProUGUI;

    private void Update()
    {
        //found something to interact with
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }
        else
        {
            Hide();
        }
    }

    private void Show(IInteractable interactable)
    {
        containerGameObject.SetActive(true);
        interactTextTextMeshProUGUI.text = interactable.GetInteractText();
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
