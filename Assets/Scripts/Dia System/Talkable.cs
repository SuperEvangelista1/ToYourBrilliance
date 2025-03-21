using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines;
    public bool[] isPlayerSpeaking;
    public Sprite NPCSprite;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
        }
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.Space) && DialougueManager.instance.dialogueBox.activeInHierarchy == false)
        {
            DialougueManager.instance.ShowDialogue(lines, isPlayerSpeaking, NPCSprite);
            //isPlayerSpeaking = !isPlayerSpeaking;
        }
    }

}



