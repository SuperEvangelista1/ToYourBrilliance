using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public Image npcAvatar;
    public Image playerAvatar;
    private bool isDialogueActive = false;
    private Movement movement;
    private Queue<string> dialogueQueue = new Queue<string>(); // To store dialogue lines

    void Start()
    {
        movement = FindObjectOfType<Movement>();
        dialogueBox.SetActive(false);
    }

    public void StartDialogue(string[] dialogue, Sprite npcPortrait)
    {
        dialogueQueue.Clear();
        foreach (string line in dialogue)
        {
            dialogueQueue.Enqueue(line);
        }

        ShowNextDialogue(npcPortrait);
        movement.DisableMovement();
        dialogueBox.SetActive(true);
    }

    public void ShowNextDialogue(Sprite npcPortrait)
    {
        if (dialogueQueue.Count > 0)
        {
            string currentLine = dialogueQueue.Dequeue();
            dialogueText.text = currentLine;
            npcAvatar.sprite = npcPortrait;
            npcAvatar.enabled = true;
            playerAvatar.enabled = false;
        }
        else
        {
            EndDialogue();
        }
    }

    public void ShowPlayerDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
        npcAvatar.enabled = false;
        playerAvatar.enabled = true;
    }

    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
        npcAvatar.enabled = false;
        playerAvatar.enabled = false;
        movement.EnableMovement();
    }

    public void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextDialogue(npcAvatar.sprite);
        }
    }
}
