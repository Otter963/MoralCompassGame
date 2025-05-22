using UnityEngine;

public class ResultsColliderScript : MonoBehaviour
{

    [SerializeField] private GameObject resultsCanvasStart;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerCamera playerCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("ResultsScreenStart");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            resultsCanvasStart.SetActive(true);
            playerMovement.enabled = false;
            playerCamera.enabled = false;
        }
    }
}
