using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdGlass : MonoBehaviour
{
    // Start is called before the first frame update

    Renderer rend;
    public GameObject mes;
    public Toggle coldtog;
    public Toggle bluetog;
   
    bool forblue;

    void Start()
    {
        rend = mes.GetComponent<Renderer>();         
        forblue = false;
        
    }

// Update is called once per frame
void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.name == "blue(Clone)" && forblue == true)
        {
            Color32 cus = new Color32(0, 75, 225, 225);
         
            rend.material.SetColor("_SurfaceColor", cus);
            rend.material.SetColor("_LiquidColor", cus);
            Destroy(collision.gameObject);
            bluetog.GetComponent<Toggle>().isOn = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "coldwater(Clone)")
        {

            float currentFill = rend.material.GetFloat("_Fill");
            currentFill += 0.001f;
            //   Debug.Log(rend.material.GetFloat("_Fill"));
            rend.material.SetFloat("_Fill", currentFill);
            Destroy(other.gameObject);
            if (currentFill >= 0.1f)
            {
                coldtog.GetComponent<Toggle>().isOn = true;
                forblue = true;
            }
        }
        if (other.gameObject.name == "hotwater(Clone)")
        {          
           Destroy(other.gameObject);
        }



    }
}
