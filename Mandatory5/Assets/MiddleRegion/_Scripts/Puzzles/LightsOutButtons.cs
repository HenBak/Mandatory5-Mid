using UnityEngine;



public class LightsOutButtons : MonoBehaviour
{

    public bool active = false;
    public GameObject LOLight;
    

    public Material LightsOutActive;
    public Material LightsOutInactive;

   
    public void ChangeActivity()
    {
        if (active)
        {
            active = false;
            Debug.Log("dababy");
            LOLight.GetComponent<MeshRenderer>().material = LightsOutInactive;
          
        }
        else
        {
            active = true;
            LOLight.GetComponent<MeshRenderer>().material = LightsOutActive;

        }

    }
}