using UnityEngine;
using UnityEngine.UI;


public class FadeIn : MonoBehaviour
{
    public float FadeSpeed = 1;

    private float alpha = 1;

    private Image panelImage;

    // Use this for initialization
    void Start ()
    {
        panelImage = GetComponent<Image>();
        panelImage.color = new Color(0, 0, 0, alpha);
    }

    // Update is called once per frame
    void Update ()
    {
        alpha -= Time.deltaTime * FadeSpeed;
        if (alpha < 0)
        {
            gameObject.SetActive(false);
        }
        panelImage.color = new Color(0, 0, 0, alpha);
    }
}
