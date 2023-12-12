using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PaperCoverGlasspart1 : MonoBehaviour
{
    public GameObject glass;
    public GameObject botglass;
    public Toggle coverpaper;
    private bool q1,q2;
    public GameObject object1; // Assign the first GameObject in the Inspector
    public GameObject object2; // Assign the second GameObject in the Inspector
    public FixedJoint fixedJoint;



    // Start is called before the first frame update
    void Start()
    {
         q1 = false;
         q2 = false;
    
        coverpaper.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (q1 == true && q2==true)
        {
        
            coverpaper.GetComponent<Toggle>().isOn = true;
            botglass.GetComponent<Rigidbody>().freezeRotation = true;
            glass.transform.position = new Vector3(botglass.transform.position.x, glass.transform.position.y, botglass.transform.position.z);

        }
    }
    public void Combine()
    {
       
    }

  

    public void OnTriggerEnter(Collider other)
    {

       
        if (other.gameObject.name == "Fa")
        {
          
            transform.position = other.transform.position;
             q1 = true;
            

        }
        if (other.gameObject.name == "Fa2")
        {
          
            glass.transform.position = new Vector3(transform.position.x, glass.transform.position.y, transform.position.z);
            q2 = true;
          

        }
        

    }


    
}
