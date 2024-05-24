using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class TriggerStarter : MonoBehaviour, IPointerClickHandler
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
    public void OnPointerClick(PointerEventData eventData)
    {
        Start();
    }
}
