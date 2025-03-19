using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour
{
    public Sprite npcPortrait; // NPC's portrait
    public string[] npcDialogues; // NPC's dialogue lines

    private DialougueManager dialogueManager;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialougueManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Press space to talk.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the prompt if the player leaves the trigger zone
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dialogueManager.dialogueBox.activeInHierarchy == false)
        {
            dialogueManager.StartDialogue(npcDialogues, npcPortrait);
        }
    }
}
