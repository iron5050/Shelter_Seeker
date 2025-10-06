using UnityEngine;
using DialogueEditor;

public class ConversastionStarter : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("script is running");
    }

    [SerializeField] private NPCConversation DogConversation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("E was pressed");
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(DogConversation);
            }
        }
    }
}