using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class newtemupdate : MonoBehaviour
{
    public Slider slider;

    public watertemN beaker;
    public watertemS beakerS;
    public GameObject normalwater;
    public GameObject Saltwater;
    public bool inwater;
    public bool inwaterS;
    // Start is called before the first frame update
    void Start()
    {       
        inwater = false;
        inwaterS = false;
        beaker = FindObjectOfType<watertemN>();
        beakerS = FindObjectOfType<watertemS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inwater == true)
        {
            slider.value = beaker.tem;
        }
     
        if (inwaterS == true)
        {
            slider.value = beakerS.tem;
        }      

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == normalwater)
        {
            inwater = true;
        }
        if (other.gameObject == Saltwater)
        {
            inwaterS = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == normalwater)
        {
            inwater = false;
        }
        if (other.gameObject == Saltwater)
        {
            inwaterS = false;
        }
    }
}
