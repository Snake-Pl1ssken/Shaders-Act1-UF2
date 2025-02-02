using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string currentSceneName; 

    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    public void playTimeline()
    {
        SceneManager.LoadScene(currentSceneName);
    }

    public void exitGame()
    { 
        Application.Quit();
    }

}
