using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colorManagement : MonoBehaviour
{

    public Image Image1, Image2, Image3, Image4, Image5;
    public Toggle Toggle1, Toggle2, Toggle3, Toggle4, Toggle5;
    // Start is called before the first frame update
    void Start()
    {
        Toggle1.GetComponent<Toggle>().isOn = false;
        Toggle2.GetComponent<Toggle>().isOn = false;
        Toggle3.GetComponent<Toggle>().isOn = false;
        Toggle4.GetComponent<Toggle>().isOn = false;
        Toggle5.GetComponent<Toggle>().isOn = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle1.GetComponent<Toggle>().isOn == true)
        {
            Image1.color = Color.green;
            Image2.color = Color.white;
        }
        if (Toggle2.GetComponent<Toggle>().isOn == true)
        {
            Image2.color = Color.green;
            Image3.color = Color.white;
        }
        if (Toggle3.GetComponent<Toggle>().isOn == true)
        {
            Image3.color = Color.green;
            Image4.color = Color.white;
        }
        if (Toggle4.GetComponent<Toggle>().isOn == true)
        {
            Image4.color = Color.green;
            Image5.color = Color.white;
        }
        if (Toggle5.GetComponent<Toggle>().isOn == true)
        {
            Image5.color = Color.green;
        }
    }



}
