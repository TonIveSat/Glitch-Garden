using UnityEngine;
using UnityEngine.SceneManagement;

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
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY, 0.5f);
    }

    public static void UnlockLevel(int level)
    {
        if (level < SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level, 1); // 1 is true
        }
        else
        {
            Debug.LogError("Trying to unlock level that is not in build order.");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        if (level < SceneManager.sceneCountInBuildSettings - 1)
        {
            return PlayerPrefs.GetInt(LEVEL_KEY + level) == 1; 
        }
        else
        {
            Debug.LogError("Trying to adress level that is not in build order.");
        }

        return false;
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty > 3f || difficulty < 1)
        {
            Debug.LogError("Difficulty out of range: " + difficulty.ToString());
        }
        else
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
