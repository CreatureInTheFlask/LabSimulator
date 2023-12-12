using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class konsan : MonoBehaviour
{
    public Toggle toggle;
    public float timess;
    public Image panel;
    // Start is called before the first frame update
    void Start()
    {
        toggle.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Mesh")
        {
            timess += Time.deltaTime;
            if(timess > 5f)
            {
                toggle.GetComponent<Toggle>().isOn = true;
                panel.color = Color.green;
            }
        }
    }
}
