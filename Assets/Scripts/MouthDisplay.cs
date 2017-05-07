using UnityEngine.UI;
using UnityEngine;

public class MouthDisplay : MonoBehaviour
{
    int totalMouths;

    private Text textBox;
	// Use this for initialization
	void Start ()
    {
        totalMouths = 0;
        textBox = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void AddMouths(int amount)
    {
        totalMouths += amount;
        UpdateMouths();
    }

    public void UseMouths(int amount)
    {
        totalMouths -= amount;
        UpdateMouths();
    }

    private void UpdateMouths()
    {
        textBox.text = totalMouths.ToString();
    }
}
