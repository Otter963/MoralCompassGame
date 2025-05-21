using UnityEngine;

//checking if the player has interacted with the NPC to disable the collider

public class NPCCheckScript : MonoBehaviour
{
    [SerializeField] private GameObject npcCheckCanvas;
    [SerializeField] private NPCInteractable npcInteractable;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has collided with collider");
            if (npcInteractable.npcTalkActive == false)
            {
                npcCheckCanvas.SetActive(true);
            }
        }
    }
}
