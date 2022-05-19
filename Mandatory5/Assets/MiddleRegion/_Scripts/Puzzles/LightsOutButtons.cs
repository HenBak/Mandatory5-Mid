using UnityEngine;
using UnityEngine.UI;


public class LightsOutButtons : MonoBehaviour
{

    public bool active = false;
    public Color32 activeColor = new Color32(200, 255, 255, 255);
    public Color32 inactiveColor = new Color32(90, 90, 90, 255);

    public void ChangeActivity()
    {
        if (active)
        {
            active = false;
            GetComponent<Image>().color = inactiveColor;
        }
        else
        {
            active = true;
            GetComponent<Image>().color = activeColor;
        }

    }
}