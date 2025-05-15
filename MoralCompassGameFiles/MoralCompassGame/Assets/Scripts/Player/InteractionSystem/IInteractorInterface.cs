using UnityEngine;

/*Reference:
Title: Unity Interaction Tutorial | How To Interact With Any Game Object (Open Chests & Doors etc) 
Author: Dan Pos
Date: 2022, April 3
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=THmW4YolDok
*/


public interface IInteractorInterface
{
    public string InteractionPrompt { get; }

    public bool Interact(Interactor interactor);
}
