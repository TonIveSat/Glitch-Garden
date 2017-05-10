using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    /// <summary>
    /// Seconds until win condition
    /// </summary>
    public int LevelDuration;

    private Slider slider;

    private bool LevelCompleted = false;

    private GameObject levelCompleteText;

    // Use this for initialization
    void Start ()
    {
        levelCompleteText = GameObject.Find("LevelComplete");
        levelCompleteText.SetActive(false);
        slider = GetComponent<Slider>();
        slider.maxValue = LevelDuration;
	}
	
	// Update is called once per frame
	void Update ()
    {
		slider.value = Time.timeSinceLevelLoad;

        if (!LevelCompleted && Time.timeSinceLevelLoad >= LevelDuration)
        {
            LevelCompleted = true;
            var audioSource = GetComponent<AudioSource>();
            levelCompleteText.SetActive(true);
            audioSource.Play();
            Invoke("LoadNextLevel", audioSource.clip.length);
        }
    }

    private void LoadNextLevel()
    {
        var levelManager = gameObject.GetComponent<LevelManager>();
        levelManager.LoadNextLevel();
    }
}
