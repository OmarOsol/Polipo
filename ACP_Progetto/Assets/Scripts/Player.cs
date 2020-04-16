using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private GameObject leftHandObj;
    private GameObject rightHandObj;
    private bool leftHand;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        leftHandObj = null;
        rightHandObj = null;
        leftHand = false; 

    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*10, 0, Input.GetAxis("Vertical")*Time.deltaTime*10));
        
        if (Input.GetKeyDown("q"))
        {
            //pick up something with left hand 
            Debug.Log("Q key pressed");
            leftHand = true;
            FindObject(leftHand);

        }
        if (Input.GetKeyDown("p"))
        {
            //pick up something with right hand
            Debug.Log("Q key pressed");
            leftHand = false;
            FindObject(leftHand);

        }
    }

    void FindObject(bool leftHand)
    {
        //finds objects with "Little Objects" tag
        // returns object to put in variable right or left handObj
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100.0f))
        {
            print("Found an object - distance: " + hit.distance);
            
        }

    }
}
