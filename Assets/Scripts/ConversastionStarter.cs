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
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E was pressed");
                ConversationManager.Instance.StartConversation(DogConversation);
            }
        }
    }
}