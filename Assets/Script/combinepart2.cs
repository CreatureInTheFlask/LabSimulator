using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class combinepart2 : MonoBehaviour
{
    public GameObject glass;
    Renderer rend;
  //  public GameObject mes;
    public Toggle combine;
    public float delay=15f;
    private float curtime=0;
    private float colour=10;
    bool trig = false;
    public float sped;
    public GameObject botglass;
    [SerializeField] RectTransform fader;




    // Start is called before the first frame update
    void Start()
    {
      //   rend = mes.GetComponent<Renderer>();
        combine.GetComponent<Toggle>().isOn = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (combine.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("w8 to delay");

            curtime += Time.deltaTime;
          //  Debug.Log(curtime);
            if (curtime > delay)
            {

                fader.gameObject.SetActive(true);
                LeanTween.scale(fader, Vector3.zero, 0f);
                LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() =>
                {
                    // fader.gameObject.SetActive(false);
                    SceneManager.LoadScene("Quiz");
                });

            }
        }      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Fa2")
        {

        //    Color32 cus = new Color32(225, 10, 10, 225);

            glass.transform.position = new Vector3(botglass.transform.position.x, glass.transform.position.y, botglass.transform.position.z);               
            combine.GetComponent<Toggle>().isOn = true;
          
            

        }
    }

 
}
