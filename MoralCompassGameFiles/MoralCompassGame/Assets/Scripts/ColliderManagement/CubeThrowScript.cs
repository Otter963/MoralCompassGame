using UnityEngine;

public class CubeThrowScript : MonoBehaviour
{
    [SerializeField] private GameObject cubeInteractCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cubeInteractCollider.SetActive(false);
            FindFirstObjectByType<AudioManager>().Play("CubeCollider");
        }
    }
}
