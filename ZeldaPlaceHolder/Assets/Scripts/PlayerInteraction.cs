using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    public GameObject currentInterObj = null;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj)
        {
            //do something with the obj
            currentInterObj.SendMessage("DoInteraction");
            currentInterObj = null;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if(other.CompareTag("InterObj"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("InterObj"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
        }
       
        
    }

}
