using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreparePlate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alcho;
    public GameObject bottle;
    public Toggle toggle1,toggle2;

    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;
        toggle2.GetComponent<Toggle>().isOn = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == alcho)
        {
            toggle1.GetComponent<Toggle>().isOn = true;
     
        }
        if (collision.gameObject == bottle)
        {         
            toggle2.GetComponent<Toggle>().isOn = true;
          
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == alcho)
        {

            toggle1.GetComponent<Toggle>().isOn = false;
         

        }
        if (collision.gameObject == bottle)
        {
            toggle2.GetComponent<Toggle>().isOn = false;
          
        }
    }

}

