using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene management

public class SceneSwitcher : MonoBehaviour
{
    // Scene name to load when triggered
    public string sceneToLoad;

    // This function will be called when an object enters the trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered is the player (you can use tag comparison)
        if (other.CompareTag("Player"))
        {
            // Switch to the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
