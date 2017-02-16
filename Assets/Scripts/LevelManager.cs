using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float AutoLoadLevelAfter = 3;

    public void Start()
    {
        if (AutoLoadLevelAfter > 0)
        {
            Invoke("LoadNextLevel", AutoLoadLevelAfter);
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("LoadLevel requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    internal void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
