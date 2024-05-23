using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogue;
    void Start()
    {
        if (dialogue != null)
        {
            ConversationManager.Instance.StartConversation(dialogue);
        }
        else
        {
            Debug.LogWarning("Dialogue is not assigned.");
        }
    }
}
