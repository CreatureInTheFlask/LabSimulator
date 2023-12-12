using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Resetbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject waterbeaker, watertermo, waterstand, waterplate, waterlight, waterfire, watersitck;
    public GameObject saltbeaker, salttermo, saltstand, saltplate, saltlight, saltfire, saltstick;
    public Transform waterbeakerp, watertermop, waterstandp, waterplatep, waterlightp, waterfirep, watersitckp;
    public Transform saltbeakerp, salttermop, saltstandp, saltplatep, saltlightp, saltfirep, saltstickp;
    public GameObject button;
    public UnityEvent onpress;
    public UnityEvent onrelease;
    public GameObject righthand;
    public GameObject lefthand;
    bool isPressed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            if (other.gameObject == righthand || other.gameObject == lefthand)
            {
             
                button.transform.localPosition = new Vector3(0, -0.3f, 0);
                isPressed = true;
            }


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == righthand || other.gameObject == lefthand)
        {
           
            button.transform.localPosition = new Vector3(0, -0.1f, 0);
            onrelease.Invoke();
            isPressed = false;
        }
    }
    public void resetwaterposition()
    {
        waterbeaker.transform.position = waterbeakerp.position;
        waterbeaker.transform.rotation = transform.rotation;
        waterstand.transform.position = waterstandp.position;
        waterstand.transform.rotation = transform.rotation;
        watertermo.transform.position = watertermop.position;
        waterplate.transform.position = waterplatep.position;
        waterlight.transform.position = waterlightp.position;
        waterfire.transform.position = waterfirep.position;
        waterfire.transform.rotation = transform.rotation;
        watersitck.transform.position = watersitckp.position;
        
    }

    public void resetsaltposition()
    {
        saltbeaker.transform.position = saltbeakerp.position;
        saltbeaker.transform.rotation = transform.rotation;
        saltstand.transform.position = saltstandp.position;
        saltstand.transform.rotation = transform.rotation;
        salttermo.transform.position = salttermop.position;
        saltplate.transform.position = saltplatep.position;
        saltlight.transform.position = saltlightp.position;
        saltfire.transform.position = saltfirep.position;
        saltfire.transform.rotation = transform.rotation;
        saltstick.transform.position = saltstickp.position;
    }

    public void reloadsceen()
    {
        SceneManager.LoadScene("Stage2");
    }

}
