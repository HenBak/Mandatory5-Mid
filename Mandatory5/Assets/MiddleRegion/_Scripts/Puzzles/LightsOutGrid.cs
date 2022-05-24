
using UnityEngine;
using UnityEngine.UI;

public class LightsOutGrid : MonoBehaviour
{
    public GameObject[] LOLight;
    public 

    void Start()
    {
        LOLight = GameObject.FindGameObjectsWithTag ("LightsOutButton"); 
    }

    void Update()
    {
      if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100))
            {
                makeFlip(int.Parse(hit.collider.gameObject.name));
                Debug.Log("works");
            }
        }
    }
    void makeFlip(int name)
    {
        flip(name);
        flip(name + 5);
        flip(name - 5);
        if(name%5 != 0)
        {
            flip(name + 1);
        }
        if(name%5 != 1)
        {
            flip(name - 1);
        }
    }
    void flip(int name)
    {
        if (name < 1 || name > 25) return;


        foreach(GameObject light in LOLight)
        {
            light.GetComponent<LightsOutButtons>().ChangeActivity();
        }
    }
}
