using UnityEngine;


/*Reference:
Title:  How to Talk to NPCs! (or Interact with any Object, Open Doors, Push Buttons, Unity Tutorial) 
Author: Code Monkey
Date: 2022, October 12
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=LdoImzaY6M4
*/


//can use the below to pretty much formulate any kind of interactable thing now...YIPPEEEEEE!!!!

public class CubeInteractable : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject cubeTouchText;

    public void CubeDoThing()
    {
        cubeTouchText.SetActive(true);
        Debug.Log("Cube touched");
    }

    public string GetInteractText()
    {
        return "Touch cube";
    }

    public void Interact(Transform interactorTransform)
    {
        //the below gets put into the interact for every interaction script thing or even collisions
        FindFirstObjectByType<AudioManager>().Play("CubeTouch");
        CubeDoThing();
    }
}
