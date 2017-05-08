using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public Camera CameraInScene;

    private GameObject defenders;

    private MouthDisplay mouthDisplay;

    // Use this for initialization
    void Start ()
    {
        mouthDisplay = GameObject.FindObjectOfType<MouthDisplay>();
        defenders = GameObject.Find("Defenders");
        if (defenders == null)
        {
            defenders = new GameObject("Defenders");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        var defender = Button.selectedDefender.GetComponent<Defender>();
        if (mouthDisplay.UseMouths(defender.Cost) == MouthDisplay.Status.Success)
        {
            BuyDefender();
        }
    }

    private void BuyDefender()
    {
        //Debug.Log(Input.mousePosition);
        var square = CalculateWorldSpacePosition(Input.mousePosition);
        var newDefender = Instantiate(Button.selectedDefender, defenders.transform) as GameObject;
        newDefender.transform.position = square;
    }

    private Vector2 CalculateWorldSpacePosition(Vector2 mousePosition)
    {
        var triplet = new Vector3(mousePosition.x, mousePosition.y, CameraInScene.transform.position.z);
        var worldPoint = CameraInScene.ScreenToWorldPoint(triplet);

        return SnapToGrid(worldPoint);
    }

    private static Vector2 SnapToGrid(Vector3 worldPoint)
    {
        return new Vector2(Mathf.Round(worldPoint.x), Mathf.Round(worldPoint.y));
    }
}
