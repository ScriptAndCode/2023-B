using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before the ballon pops
    public float scaleToIncrease = 0.10f; // Scale increase each time the balloon is clicked


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
        {
            // Reduce clicks by one:
            clickToPop --;

            // Other methods to reduce variable by 1:
            /* 
            clickToPop = clickToPop - 1;
            clickToPop -= 1;
            */

            //Inflate balloon:
            transform.localScale += Vector3.one * scaleToIncrease; // Vector3 is 3 dimensions?
        
            // Check to see if clickToPop has reached zero/check to see if the balloon pops:
            if(clickToPop == 0)
            {
                Destroy(gameObject); // Destroy and remove popped balloon.
            }

        }
    
}
