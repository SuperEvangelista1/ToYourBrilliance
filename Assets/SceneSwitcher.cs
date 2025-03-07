using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSceneSwitcher : MonoBehaviour
{
    public Button yourButton; // Drag your button in the Inspector

    void Start()
    {
        yourButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Switch to the scene called "NextScene"
        SceneManager.LoadScene("NextScene");
    }
}
