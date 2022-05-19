
using UnityEngine;
using UnityEngine.UI;

public class LightsOutGrid : MonoBehaviour
{
   void makeWork(int button)
    {
        turn (button);
        turn (button + 5);
        turn(button - 5);

        if(button%5! = 0)
        {
            turn(button + 1);
        } 
        if( button%5! = 1)
        {
            turn(button - 1);
        }
    }
    void turn(int button
        )
    {
        if (button < 1 || button > 25) return;
    }
}
