using UnityEngine;
using DialogueEditor;

public class ConversastionStarterHorse : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("script is running");
    }

    [SerializeField] private NPCConversation HorseConversation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.visible = true;
                Debug.Log("E was pressed");
                ConversationManager.Instance.StartConversation(HorseConversation);
            }
        }
    }
}