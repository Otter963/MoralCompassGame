using UnityEngine;

/*Reference:
Title: FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial 
Author: Dave / GameDevelopment
Date: 2022, February 7
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=f473C43s8nE
*/

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPos;

    private void Update()
    {
        transform.position = cameraPos.position;
    }
}
