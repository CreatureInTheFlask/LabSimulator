using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class respawnitems : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject waterbeaker,watertermo,waterstand,waterplate,waterlight,waterfire,watersitck;
    public GameObject saltbeater, salttermo, saltstand, saltplate, saltlight, saltfire, saltstick, saltmodel;
    public Transform waterbeakerp, watertermop, waterstandp, waterplatep, waterlightp, waterfirep, watersitckp;
    public Transform saltbeaterp, salttermop, saltstandp, saltplatep, saltlightp, saltfirep, saltstickp, saltmodelp;
    
   
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == waterbeaker)
        {
            waterbeaker.transform.position = waterbeakerp.transform.position;
        }
        if (collision.gameObject == watertermo)
        {
            watertermo.transform.position = watertermop.transform.position;
        }
        if (collision.gameObject == waterstand)
        {
            waterstand.transform.position = waterstandp.transform.position;
        }
        if (collision.gameObject == waterplate)
        {
            waterplate.transform.position = waterplatep.transform.position;
        }
        if (collision.gameObject == waterlight)
        {
            waterlight.transform.position = waterlightp.transform.position;
        }
        if (collision.gameObject == waterfire)
        {
            waterfire.transform.position = waterfirep.transform.position;
        }
        if (collision.gameObject == watersitck)
        {
            watersitck.transform.position = watersitckp.transform.position;
        }



        if (collision.gameObject == saltbeater)
        {
            saltbeater.transform.position = saltbeaterp.transform.position;
        }
        if (collision.gameObject == salttermo)
        {
            salttermo.transform.position = salttermop.transform.position;
        }
        if (collision.gameObject == saltstand)
        {
            saltstand.transform.position = saltstandp.transform.position;
        }
        if (collision.gameObject == saltplate)
        {
            saltplate.transform.position = saltplatep.transform.position;
        }
        if (collision.gameObject == saltlight)
        {
            saltlight.transform.position = saltlightp.transform.position;
        }
        if (collision.gameObject == saltfire)
        {
            saltfire.transform.position = saltfirep.transform.position;
        }
        if (collision.gameObject == saltstick)
        {
            saltstick.transform.position = saltstickp.transform.position;
        }
        if (collision.gameObject == saltmodel)
        {
            saltmodel.transform.position = saltmodelp.transform.position;
        }

    }
}
