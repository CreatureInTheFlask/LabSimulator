using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CombineWaterTest : MonoBehaviour
{
    public GameObject glass;
    Renderer rend;
    public GameObject mes;
    public Toggle combine;
    public float delay=15f;
    private float curtime=0;
    private float colour=10;
    bool trig = false;
    public float sped;
    [SerializeField] RectTransform fader;




    // Start is called before the first frame update
    void Start()
    {
         rend = mes.GetComponent<Renderer>();
        combine.GetComponent<Toggle>().isOn = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (combine.GetComponent<Toggle>().isOn == true)
        {
            curtime += Time.deltaTime;
          //  Debug.Log(curtime);
            if (curtime > delay)
            {

                fader.gameObject.SetActive(true);
                LeanTween.scale(fader, Vector3.zero, 0f);
                LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() =>
                {
                    // fader.gameObject.SetActive(false);
                    SceneManager.LoadScene("lab1part2");
                });

            }
        }
       if (trig == true)
        {
            colour += Time.deltaTime+sped;
            if (colour <= 110) { 
            Color32 cus = new Color32(225, (byte)colour, (byte)colour, 225);
            rend.material.SetColor("_SurfaceColor", cus);
            rend.material.SetColor("_LiquidColor", cus);
            }
            //  Debug.Log(a+"d");
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Fa2")
        {

            Color32 cus = new Color32(225, 10, 10, 225);

            glass.transform.position = new Vector3(transform.position.x, glass.transform.position.y, transform.position.z);         
        //    rend.material.SetColor("_SurfaceColor", cus);
         //   rend.material.SetColor("_LiquidColor", cus);
          //  another.material.SetColor("_SurfaceColor", Color.green);
          //  another.material.SetColor("_LiquidColor", Color.green);
            combine.GetComponent<Toggle>().isOn = true;
            if (rend.material.GetColor("_SurfaceColor") == cus)
            {
                trig = true;
            }
            

        }
    }

 
}
