using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lighter : MonoBehaviour
{
    public GameObject flame;
    
   
    // Start is called before the first frame update
    void Start()
    {
        flame.SetActive(false);   
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void turnonlight()
    {
   
        flame.SetActive(true);

       
      
    }

    public void turnofflight()
    {
        flame.SetActive(false);
    }


   
}
