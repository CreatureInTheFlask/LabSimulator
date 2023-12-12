using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Quizz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject nextquestion;
    public GameObject oldquestion;
    public int sscore;
    void Start()
    {
        nextquestion.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void correctawnser()
    {
        Debug.Log("correct");
      
        nextquestion.SetActive(true);
        oldquestion.gameObject.SetActive(false);


    }
    public void conslustionwrong()
    {
        Debug.Log("wrong");
    }

    public void quizzwrong()
    {
        Debug.Log("wrong");
        nextquestion.SetActive(true);
        oldquestion.gameObject.SetActive(false);
    }
    public void increasescore()
    {
       sscore = sscore+1;
    }


    public void closetab()
    {
        oldquestion.SetActive(false);
    }
}
