using UnityEngine;

public class Defender : MonoBehaviour
{
    private int totalStars = 0;

    private MouthDisplay mouthDisplay;

    // Use this for initialization
    void Start () {
        mouthDisplay = FindObjectOfType<MouthDisplay>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(name + " triggered by OnTriggerEnter2D");
    }

    private void AddStars(int amount)
    {
        mouthDisplay.AddMouths(amount);
    }
}
