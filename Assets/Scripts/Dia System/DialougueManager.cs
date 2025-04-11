using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougueManager : MonoBehaviour
{
    public static DialougueManager instance;
    public GameObject dialogueBox;
    public Text dialogueText;
    public bool dialogueSpeaker;

    public Image characterImage;

    [TextArea(1, 3)]
    public string[] dialougeLines;
    [SerializeField] public int currentLine;
    public bool[] dialogueIsPlayer;



    public Sprite npcSprite;
    public Sprite playerSprite;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
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
        if (dialogueBox.activeInHierarchy)
        {
            if (Input.GetMouseButtonUp(0))
            {
                currentLine++;
                if (currentLine < dialougeLines.Length) {
                    dialogueText.text = dialougeLines[currentLine];
                    dialogueSpeaker = dialogueIsPlayer[currentLine];
                }
                else
                {
                    dialogueBox.SetActive(false);
                    FindObjectOfType<Movement>().canMove = true;

                }
            }
        }

        if (dialogueSpeaker)
        {
            characterImage.sprite = playerSprite;
        }
        else
        {
            characterImage.sprite = npcSprite;
        }
    }

    public void ShowDialogue(string[] _newLines, bool[] isPlayerSpeaking, Sprite npcSprites)
    {
        npcSprite = npcSprites;
        currentLine = 0;
        dialougeLines = _newLines;
        dialogueText.text = dialougeLines[currentLine];
        dialogueBox.SetActive(true);

        dialogueIsPlayer = isPlayerSpeaking;
        dialogueSpeaker = dialogueIsPlayer[currentLine];

        FindObjectOfType<Movement>().canMove = false;
    }

}