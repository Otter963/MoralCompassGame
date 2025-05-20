using UnityEngine;

/*Reference:
Title:  How to Talk to NPCs! (or Interact with any Object, Open Doors, Push Buttons, Unity Tutorial) 
Author: Code Monkey
Date: 2022, October 12
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=LdoImzaY6M4
*/

public interface IInteractable
{
    void Interact(Transform interactorTransform);
    string GetInteractText();
}
