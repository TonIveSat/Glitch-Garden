using UnityEngine.UI;
using UnityEngine;

public class MouthDisplay : MonoBehaviour
{
    public int TotalMouths = 100;

    public enum Status { Success, Failure }

    private Text textBox;
	// Use this for initialization
	void Start ()
    {
        textBox = GetComponent<Text>();
        UpdateMouths();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void AddMouths(int amount)
    {
        TotalMouths += amount;
        UpdateMouths();
    }

    public Status UseMouths(int amount)
    {
        if (TotalMouths >= amount)
        {
            TotalMouths -= amount;
            UpdateMouths();
            return Status.Success;
        }
        else
        {
            return Status.Failure;
        }
    }

    private void UpdateMouths()
    {
        textBox.text = TotalMouths.ToString();
    }
}
