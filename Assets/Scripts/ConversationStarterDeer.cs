using UnityEngine;
using DialogueEditor;

public class ConversationStarterDeer : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("script is running");
    }

    [SerializeField] private NPCConversation DeerConversation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E was pressed");
                ConversationManager.Instance.StartConversation(DeerConversation);
            }
        }
    }
}
