using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    private const string MASTER_VOLUME_KEY = "master_volume";

    private const string DIFFICULTY_KEY = "difficulty";

    private const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume > 1f || volume < 0)
        {
            Debug.LogError("Volume out of range: " + volume.ToString());
        }
        else
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
	}

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
}
