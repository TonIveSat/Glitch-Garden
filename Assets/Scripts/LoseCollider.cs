using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private GameObject gameOverText;

    private bool gameOver = false;

    // Use this for initialization
    void Start () {
        gameOverText = GameObject.Find("GameOver");
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameOver)
        {
            gameOver = true;
            var audioSource = GetComponent<AudioSource>();
            gameOverText.SetActive(true);
            audioSource.Play();
            Invoke("LoadLoseScene", audioSource.clip.length);
        }
    }

    private void LoadLoseScene()
    {
        new LevelManager().LoadLevel("03 Lose");
    }
}
