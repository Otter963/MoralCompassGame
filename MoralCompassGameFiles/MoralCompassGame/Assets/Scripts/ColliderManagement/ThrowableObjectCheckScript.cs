using UnityEngine;

public class ThrowableObjectCheckScript : MonoBehaviour
{

    [SerializeField] private GameObject progressionWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "canPickUp")
        {
            Debug.Log("Cube is in the collider!");
            progressionWall.SetActive(false);
        }
    }
}
