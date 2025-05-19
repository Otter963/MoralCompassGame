using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Reference:
Title: FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial 
Author: Dave / GameDevelopment
Date: 2022, February 7
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=f473C43s8nE
*/

public class PlayerCamera : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform playerOrientation;

    float xRotation;
    float yRotation;

    [SerializeField] private PauseMenuScript pauseMenuScript;

    private void Start()
    {
        //makes sure the cursor doesn't show up as the player plays

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //if the pause menu is active

        if (pauseMenuScript.isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //getting mouse input:

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        //making sure the player cannot look up or down more than 90 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotating camera and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        playerOrientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
