using UnityEngine;

/*Reference:
Title:  How to Talk to NPCs! (or Interact with any Object, Open Doors, Push Buttons, Unity Tutorial) 
Author: Code Monkey
Date: 2022, October 12
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=LdoImzaY6M4
*/

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    [SerializeField] private GameObject npcText;
    [SerializeField] private GameObject npcCheckCollider;
    [SerializeField] private GameObject npcCheckCanvas;
    public bool npcTalkActive = false;

    public void Interact()
    {
        npcText.SetActive(true);
        npcTalkActive = true;
        npcCheckCollider.SetActive(false);
        npcCheckCanvas.SetActive(false);
        Debug.Log("Interact!");
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public void Interact(Transform interactorTransform)
    {
        FindFirstObjectByType<AudioManager>().Play("NPCInteraction");
        Interact();
    }
}
