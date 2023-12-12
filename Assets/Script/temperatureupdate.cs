using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class temperatureupdate : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    
    public watertemS watertem;
    public bool inglass;
    
    void Start()
    {
        watertem = FindObjectOfType<watertemS>();
        inglass = false;
    }

    // Update is called once per frame
    void Update()
    {
        float currentFill = rend.material.GetFloat("_Fill");
        if (currentFill > -0.15 && inglass == false)
        {           
            currentFill -= 0.015f * Time.deltaTime;
            rend.material.SetFloat("_Fill", currentFill);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        float currentFill = rend.material.GetFloat("_Fill");      
      
        if (other.gameObject.name == "Mesh" && currentFill<0.15f )
        {
           
            if (watertem.tem != 0)
            {
             
                currentFill = watertem.tem;
                rend.material.SetFloat("_Fill", currentFill);
            }
            inglass = true;
        }
      

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Mesh")
        {
            inglass = false; 
        }
    }

}
