using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public int minutes;
    public int seound;
    private float timer = 0.0f;
    public bool grabed;
    void Start()
    {
        grabed = false;
    }

    // Update is called once per frame
    void Update()
    {             
        timeingame();
    }
    public void timeingame()
    {

        timer += Time.deltaTime;
        minutes = Mathf.FloorToInt(timer / 60f);
        seound = Mathf.FloorToInt(timer - minutes * 60);

    }

    public void grabbottle()
    {
        if (grabed==false)
        {          
            Debug.Log("Grab bottle at " + string.Format("{0:00}:{1:00}", minutes, seound+" minutes "));
            grabed = true;
        }      
    }
    public void grabplate()
    {
        if (grabed == false)
        {
            Debug.Log("Grab plate at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void grabligther()
    {
        if (grabed == false)
        {
            Debug.Log("Grab ligther at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void grabStandAndHandle()
    {
        if (grabed == false)
        {
            Debug.Log("Grab Stand and handle at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void grabThermometer()
    {
        if (grabed == false)
        {
            Debug.Log("Grab Thermometer at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void grabAlcoholBurner()
    {
        if (grabed == false)
        {
            Debug.Log("Grab Alcohol burner at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void grabStirringRod()
    {
        if (grabed == false)
        {
            Debug.Log("Grab Stirring rod at " + string.Format("{0:00}:{1:00}", minutes, seound + " minutes "));
            grabed = true;
        }
    }
    public void ungrab()
    {
        grabed=false;
        Debug.Log("UnGrab at "+string.Format("{0:00}:{1:00}", minutes, seound)+ " minutes ");
    }
}
