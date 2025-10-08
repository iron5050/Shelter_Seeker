using UnityEngine;
using DialogueEditor;

public class ConversationStarterChiken : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("script is running");
    }

    [SerializeField] private NPCConversation ChikenConversation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.visible = true;
                Debug.Log("E was pressed");
                ConversationManager.Instance.StartConversation(ChikenConversation);
            }
        }
    }
}

