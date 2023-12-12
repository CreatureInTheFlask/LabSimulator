using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class holdtermometor : MonoBehaviour
{
    // Start is called before the first frame update

 
    public GameObject object1; // Assign the first GameObject in the Inspector
    public GameObject object2; // Assign the second GameObject in the Inspector
    public Toggle toggle;
 
    float maxRange = 0.7f;
    public FixedJoint fixedJoint;
    void Start()
    {
        toggle.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "handle")
        {

          
            fixedJoint = object1.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = object2.GetComponent<Rigidbody>();
            toggle.GetComponent<Toggle>().isOn = true;
            


        }
        if (toggle.GetComponent<Toggle>().isOn == true){
        
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(fixedJoint);
      
    }

    public void DisableFixedJoint()
    {
        if (fixedJoint != null)
        {
            Destroy(fixedJoint); 
            fixedJoint = null; 
        }
    }

    public void EnableFixedJoint()
    {
        fixedJoint = object1.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = object2.GetComponent<Rigidbody>(); // Replace with the appropriate connected body.
    }

}
