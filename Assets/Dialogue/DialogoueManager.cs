using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DialogoueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Animator anim;
    public MainCam cam;

    public Text nameText;
    public Text text;
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    // Update is called once per frame
    public void StartConversation(Diaolog dialogue)
    {
        anim.SetBool("isOpen",true);
        
        sentences.Clear();

        nameText.text = dialogue.name;

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
         DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndConversation();
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void EndConversation()
    {
        anim.SetBool("isOpen", false);
    }

    IEnumerator TypeSentence(string sentence)
    {
        text.text = "";
        foreach(char character in sentence.ToCharArray())
        {
            yield return 0.1;
            text.text += character;
            

        }
    }

    public void negativeAnswer()
    {
        MainCam.instance.Shake();
        Debug.Log("Heey");
    }



}
