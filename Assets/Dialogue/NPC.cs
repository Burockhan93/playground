using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Diaolog dialogue;
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<DialogoueManager>().StartConversation(dialogue);
    }

    void OnTriggerExit(Collider other)
    {
        FindObjectOfType<DialogoueManager>().EndConversation();
    }

}
