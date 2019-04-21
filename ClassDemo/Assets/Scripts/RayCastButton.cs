using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastButton : MonoBehaviour
{

    //USAGE: put this on an object (with a collider) to make it clickable
    //FUNCTION: shoot raycast based on mouse cursor to detect any colliders
    // Update is called once per frame
    void Update()
    {
        //STEP 1: generate a "Ray" variable
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //STEP 2: visualize the ray
        Debug.DrawRay(myRay.origin, myRay.direction * 1000f, Color.red);
        
        //STEP 3: generate a RaycastHit variable
        // "RaycastHit" is a type of variable that has more info about what it hit.
        RaycastHit myRayHitInfo = new RaycastHit();

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(myRay, out myRayHitInfo, 1000f))
            {
                //STEP 5: do something
                //Destroy(myRayHitInfo.collider.gameObject);
                
                myRayHitInfo.transform.Translate(0f, 1f, 0f);

                myRayHitInfo.transform.localScale *= 0.5f;
            }        
        }
    }
    
    //faster way
    private void OnMouseDown()
    {
        Debug.Log("you clicked on me!");
    }
}
