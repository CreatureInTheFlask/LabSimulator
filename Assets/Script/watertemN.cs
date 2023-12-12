using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class watertemN : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flame;
    public float boiltime=0.0f;
    
    public GameObject boil1,boil2,boil3,boil4,boil5;
    public GameObject salt;
    public int seound;
    public bool mixed;
    public bool touchfire;
    public float tem;
    public float maxtem;
    public Renderer rend;
    public Toggle toggle;
    private float lastExecutionTime;
    public GameObject starttimer;
 

    void Start()
    {
         lastExecutionTime = Time.time;
        boil1.SetActive(false);
        boil2.SetActive(false);
        boil3.SetActive(false);
        boil4.SetActive(false);
        boil5.SetActive(false);
        tem = 26f;
        maxtem = 100f;
        mixed = false;
        toggle.GetComponent<Toggle>().isOn = false;
        
        starttimer.SetActive(false);
       

    }

    // Update is called once per frame
    void Update()
    {
        if (touchfire == true)
        {
            boiltime += Time.deltaTime*2f;
            if (Time.time - lastExecutionTime >= 0.5f)
            {              
                increasetem();               
                lastExecutionTime = Time.time;              
            }
        }
        

       
          
        
      
    }

    private void OnTriggerStay(Collider other)
    {

        float currentFill = rend.material.GetFloat("_Fill");
        if (other.gameObject == flame && mixed == false)
        {
           
            touchfire = true;
            starttimer.SetActive(true);
            if (boiltime >= 30f)
            {

                boil1.SetActive(true);


            }
            if (boiltime >= 60f)
            {
                currentFill = 0.01f;
                rend.material.SetFloat("_Fill", currentFill);



            }
            if (boiltime >= 90f)
            {
                currentFill = 0f;
                rend.material.SetFloat("_Fill", currentFill);



            }
            if (boiltime >= 120f)
            {
                currentFill = -0.01f;
                rend.material.SetFloat("_Fill", currentFill);
                boil2.SetActive(true);


            }
            if (boiltime >= 150f)
            {
                currentFill = -0.02f;
                rend.material.SetFloat("_Fill", currentFill);
                boil3.SetActive(true);


            }
            if (boiltime >= 180f)
            {
                currentFill = -0.02f;
                rend.material.SetFloat("_Fill", currentFill);



            }
            if (boiltime >= 210f)
            {
                currentFill = -0.02f;
                rend.material.SetFloat("_Fill", currentFill);
                boil4.SetActive(true);


            }
            if (boiltime >= 240f)
            {



            }
            if (boiltime >= 270f)
            {
                currentFill = -0.02f;
                rend.material.SetFloat("_Fill", currentFill);
                boil5.SetActive(true);




            }      
        }




        if (other.gameObject.name=="salt(Clone)")
        {
         
            Destroy(other.gameObject);
            Debug.Log("saltin");
            mixed = true;



        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plate" && mixed == false)
        {
            toggle.GetComponent<Toggle>().isOn = true;
        }
        else if (collision.gameObject.name == "Plate" && mixed == true)
        {
          
        }
    }

    public void increasetem()
    {
        if (boiltime < 60f)
        {
            tem = tem + 0.1833f;
        }
        else if (boiltime < 120f)
        {
            tem = tem + 0.2333f;
        }
        else if (boiltime < 180f)
        {
            tem = tem + 0.1833f;
        }
        else if (boiltime < 240f)
        {
            tem = tem + 0.1333f;
        }
        else if (boiltime < 300f)
        {
            tem = tem + 0.0833f;
        }
        else if (boiltime < 360f)
        {
            tem = tem + 0.0833f;
        }
        else if (boiltime < 420f)
        {
            tem = tem + 0.1333f;
        }
        else if (boiltime < 480f)
        {
            tem = tem + 0.1166f;
        }
        else if (boiltime > 540f)
        {
            tem = tem + 0.05f;
        }

    }

}
