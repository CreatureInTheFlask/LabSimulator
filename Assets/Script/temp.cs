using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class temp : MonoBehaviour
{
    public GameObject prefab;
    public Transform target;
    public bool open;
    //  public ParticleSystem parti;
    // Start is called before the first frame update
    public Toggle hottoggle;
   
    private void Start()
    {
        open = false;
      //  parti = transform.parent.GetComponentInChildren<ParticleSystem>();
     
    }
    public void Update()
    {
        if (open == true && name == "Hotwater" && hottoggle.GetComponent<Toggle>().isOn == false)
        {
            pushwater();
            //    parti.Play();


        }
        else if (open == true && name == "Coldwater" && hottoggle.GetComponent<Toggle>().isOn == true)
        {
               pushwater();
        //    parti.Play();
           
          
        }
        
     

    }

    public void pushwater()
    {

        Instantiate(prefab, target.position, target.rotation);

    }


    
       public void push()
        {    
        open = true;
        }
    public void pull()
    {
    //   parti.Stop();
        open = false;
    }
  
    
}

