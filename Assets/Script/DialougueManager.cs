using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougueManager : MonoBehaviour
{
    public static DialougueManager instance;
    public GameObject dialogueBox;//display
    public Text dialogueText ;

    [TextArea(1, 3)]
    public string[] dialougeLines;
    [SerializeField] private int currentLine;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            if (instance != this) 
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    
    private void Start()
    {
        dialogueText.text = dialougeLines[currentLine];
    }

    private void Update()
    {
        if (dialogueBox.activeInHierarchy) {
            if (Input.GetMouseButtonUp(0))
            {
                currentLine++;
                if (currentLine < dialougeLines.Length)
                    dialogueText.text = dialougeLines[currentLine];
                else { 
                    dialogueBox.SetActive(false);
                    FindObjectOfType<Movement>().canMove = true;

                }
            }
        }
    }

    public void ShowDialogue(string[] _newLines)
    {
        dialougeLines = _newLines;
        currentLine = 0;
        dialogueText.text = dialougeLines[currentLine];
        dialogueBox.SetActive(true);

        FindObjectOfType<Movement>().canMove = false;
    }

}
