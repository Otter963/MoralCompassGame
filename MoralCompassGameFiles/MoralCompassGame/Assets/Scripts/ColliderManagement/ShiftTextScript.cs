using UnityEngine;

public class ShiftTextScript : MonoBehaviour
{
    [SerializeField] private GameObject wasdCanvas;
    [SerializeField] private GameObject shiftCanvas;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            wasdCanvas.SetActive(false);
            shiftCanvas.SetActive(true);
        }
    }
}
