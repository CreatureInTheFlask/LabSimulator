using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watertest : MonoBehaviour
{
    Renderer rend;
    public GameObject mes;
    public GameObject coldtog;
    public GameObject hottog;
    public GameObject redtog;
    public GameObject bluetog;
   public ParticleSystem steam;
    bool forred;
    bool forblue;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("start"+GetComponent<Renderer>().material.GetFloat("_Fill"));
        rend = mes.GetComponent<Renderer>();
        coldtog.GetComponent<Toggle>().isOn = false;
        hottog.GetComponent<Toggle>().isOn = false;
        redtog.GetComponent<Toggle>().isOn = false;
        bluetog.GetComponent<Toggle>().isOn = false;
        steam.GetComponent < ParticleSystem>();
        steam.Stop();
        forred = false;
        forblue = false;
        

    }

    // Update is called once per frame
  

     void OnCollisionEnter(Collision collision)
    {

       

        if (collision.collider.name == "red(Clone)" && forred == true)
        {
            Color32 cus = new Color32(225, 10, 10, 225);
            //var foodcolor = collision.collider.GetComponent<Renderer>().material.color;
            rend.material.SetColor("_SurfaceColor", cus);
            rend.material.SetColor("_LiquidColor", cus);
            Destroy(collision.gameObject);
            
            redtog.GetComponent<Toggle>().isOn = true;
           // Debug.Log(foodcolor);
        }
        if (collision.collider.name == "blue(Clone)" && forblue == true)
        {
            Color32 cus = new Color32(0, 75, 225, 225);
           // var foodcolor = collision.collider.GetComponent<Renderer>().material.color;
            rend.material.SetColor("_SurfaceColor", cus);
            rend.material.SetColor("_LiquidColor", cus);
            Destroy(collision.gameObject);
            bluetog.GetComponent<Toggle>().isOn = true;
        }
     
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "hotwater(Clone)")
        {

            float currentFill = rend.material.GetFloat("_Fill");
            currentFill += 0.001f;
          //  Debug.Log(rend.material.GetFloat("_Fill"));
            rend.material.SetFloat("_Fill", currentFill);
            Destroy(other.gameObject);
            if (currentFill >= 0.1f)
            {
                hottog.GetComponent<Toggle>().isOn = true;
                forred = true;
                steam.Play();
            }
         
            
        }

       /* if (other.gameObject.name == "coldwater(Clone)")
        {

            float currentFill = rend.material.GetFloat("_Fill");
            currentFill += 0.001f;
         //   Debug.Log(rend.material.GetFloat("_Fill"));
            rend.material.SetFloat("_Fill", currentFill);
            Destroy(other.gameObject);
            if (currentFill >= 0.1f)
            {
                coldtog.GetComponent<Toggle>().isOn = true;
                forblue=true;
            }
        }*/



    }


}


