using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class fontcontroll : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text q1, q2, q3, q4, q5, q6;
    public Toggle tog1,tog2,tog3,tog4,tog5,tog6;
    void Start()
    {
        q1.color = Color.white;
        q2.color = Color.red;
        q3.color = Color.red;
        q4.color = Color.red;
        q5.color = Color.red;
        q6.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        setcolor();
        if (tog1.GetComponent<Toggle>().isOn == true)
        {
            q1.color = Color.green;
        }
        if (tog2.GetComponent<Toggle>().isOn == true)
        {
            q2.color = Color.green;
        }
        if (tog3.GetComponent<Toggle>().isOn == true)
        {
            q3.color = Color.green;
        }
        if (tog4.GetComponent<Toggle>().isOn == true)
        {
            q4.color = Color.green;
        }
        if (tog5.GetComponent<Toggle>().isOn == true)
        {
            q5.color = Color.green;
        }
        if (tog6.GetComponent<Toggle>().isOn == true)
        {
            q6.color = Color.green;
        }
    }
    void setcolor()
    {
        
           
        if (tog2.GetComponent<Toggle>().isOn == false && tog1.GetComponent<Toggle>().isOn == true)
            {
                q2.color = Color.white;
            }       
        if (tog3.GetComponent<Toggle>().isOn == false && tog2.GetComponent<Toggle>().isOn == true)
        {
            q3.color = Color.white;
        }
        if (tog4.GetComponent<Toggle>().isOn == false && tog3.GetComponent<Toggle>().isOn == true)
        {
            q4.color = Color.white;
        }
        if (tog5.GetComponent<Toggle>().isOn == false && tog4.GetComponent<Toggle>().isOn == true)
        {
            q5.color = Color.white;
        }
        if (tog6.GetComponent<Toggle>().isOn == false && tog5.GetComponent<Toggle>().isOn == true)
        {
            q6.color = Color.white;
        }
    }
}
