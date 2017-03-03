using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public LevelManager LevelManager;

    public Slider VolumeSlider;

    public Slider DifficultySlider;

    private MusicManager musicManager;

	// Use this for initialization
	void Start ()
    {
        musicManager = FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    public void SetDefaults()
    {
        VolumeSlider.value = 0.5f;
        DifficultySlider.value = 1;
    }

    public void VolumeChanged()
    {
        if (musicManager != null)
        {
            musicManager.ChangeVolume(VolumeSlider.value);
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
        LevelManager.LoadLevel("01a Start");
    }
}
