using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*Reference:
Title: Unity Interaction Tutorial | How To Interact With Any Game Object (Open Chests & Doors etc) 
Author: Dan Pos
Date: 2022, April 3
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=THmW4YolDok
*/

//this script is just used as a point of reference for different scenarios

public class Chest : MonoBehaviour, IInteractorInterface
{
    [SerializeField] private string prompt;

    //public string InteractionPrompt { get => prompt; }
    public string InteractionPrompt => prompt;
    public bool Interact(Interactor interactor)
    {
        //Below is where logic can be put with WHAT you want the object to do. For example, with a chest to display the inventory menu
        Debug.Log("Opening Chest!");
        return true;
    }
}
