using UnityEngine;

public class Delay : MonoBehaviour
{
    public int WaitSeconds;

    private static bool started = false;

    private System.DateTime startupTime;

    public void Start()
    {
        Debug.Log("Delay started");
        startupTime = System.DateTime.Now;
    }

    public void Update()
    {
        if (!started)
        {
            if (startupTime.AddSeconds(WaitSeconds) < System.DateTime.Now)
            {
                started = true;
                Debug.Log("LoadNextLevel");
                FindObjectOfType<LevelManager>().GetComponent<LevelManager>().LoadNextLevel();
            }
        }
    }
}
