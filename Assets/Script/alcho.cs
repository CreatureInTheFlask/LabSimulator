using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alcho : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flame;
    public GameObject lighter;
    public Toggle toggle;
    public Image panel1;
    public Image panel2;
    void Start()
    {
        flame.SetActive(false);
        toggle.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "flame")
        {
            flame.SetActive(true);
           
            toggle.GetComponent<Toggle>().isOn = true;
            panel1.color = Color.green;
            panel2.color = Color.white;
            
        }
    }
}
