using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Defender;

    public static GameObject selectedDefender;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        // Debug.Log(name + " clicked");

        SetColorOfAllButtons(Color.black);
        SetColorOfButton(Color.white, this);
        selectedDefender = Defender;
    }

    private void SetColorOfAllButtons(Color color)
    {
        foreach (var b in FindObjectsOfType<Button>())
        {
            SetColorOfButton(color, b);
        }
    }

    private static void SetColorOfButton(Color color, Button b)
    {
        switch (b.name)
        {
            case "Flesh Eater":
                b.transform.FindChild("Body").GetComponent<SpriteRenderer>().color = color;
                b.transform.FindChild("Mouth").GetComponent<SpriteRenderer>().color = color;
                break;
            default:
                b.GetComponent<SpriteRenderer>().color = color;
                break;
        }
    }
}
