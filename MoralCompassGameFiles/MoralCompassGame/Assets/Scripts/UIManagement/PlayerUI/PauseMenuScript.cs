using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public bool isPaused = false;

    [SerializeField] private GameObject pauseMenuCanvas;

    [SerializeField] private GameObject playerUICanvas;

    [SerializeField] private PlayerCamera playerCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                playerCamera.enabled = true;
                ResumeGame();
            }
            else
            {
                playerCamera.enabled = false;
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restartlevel()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
