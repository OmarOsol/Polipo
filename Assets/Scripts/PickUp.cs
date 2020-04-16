using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform myDestination;
    private bool isPickedUp;

    private void Start()
    {
        isPickedUp = false;

    }

    private void Update()
    {

        if (Input.GetKeyDown("e")) //servirà condizione per la quale è nel raggio di azione del personaggio
        {
            Debug.Log("e key pressed");
            if (!isPickedUp)
            {
                Debug.Log("not p");
                //cancels gravity
                GetComponent<Rigidbody>().useGravity = false;
                this.transform.position = myDestination.position;
                this.transform.parent = GameObject.FindGameObjectWithTag("Destination").transform;
                isPickedUp = true;
            }

           else
            {

                Debug.Log(" p");
                //cancels gravity
                GetComponent<Rigidbody>().useGravity = true;
                
                this.transform.parent = null;
                isPickedUp = false;
            }



        }
        //come faccio a lasciarlo???
    }

   


    



}
