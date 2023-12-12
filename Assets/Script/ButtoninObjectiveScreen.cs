using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtoninObjectiveScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objective,howtoplay,knowledge;
    public int page;

    void Start()
    {
       page = 0;
        objective.SetActive(true);
        howtoplay.SetActive(false);
        knowledge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (page == 0)
        {
            objective.SetActive(true);
            howtoplay.SetActive(false);
            knowledge.SetActive(false);
        }
        else if (page == 1)
        {
            knowledge.SetActive(true);
            objective.SetActive(false);
            howtoplay.SetActive(false);
        }
        else if (page == 2)
        {
            howtoplay.SetActive(true);
            objective.SetActive(false);
            knowledge.SetActive(false);
        }
    }

    public void nextpage()
    {
        if(page < 2)
        {
            page += 1;
        }
        if(page == 2)
        {
            SceneManager.LoadScene("Stage2");
        }
        
    }
    public void backpage()
    {
        if (page >0)
        {
            page -= 1;
        }
    }
}
