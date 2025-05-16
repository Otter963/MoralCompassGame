using UnityEngine;
using UnityEngine.SceneManagement;

/*Reference:
Title: Main menu - FPS game in unity with Blender [Video]
Author: Single Sapling Games
Date: 2022, January 29
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=oETf6hmH4ug
*/

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject optionsMenu;

    private void Start()
    {
        ActivateMainMenu(true);
    }

    public void ActivateMainMenu(bool state)
    {
        mainMenu.SetActive(state);
        optionsMenu.SetActive(!state);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
