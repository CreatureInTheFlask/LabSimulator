using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int totalscore;
    public Button correct;
    public GameObject Panel,Panel1,Panel2;
    public GameObject q1, q2, q3;
    public TMP_Text showscore;
    bool done;

    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel.activeSelf == true && done == false)
        {
            increasescore();
        }
        if (Panel2.activeSelf == true&& done == false)
        {

            increasescore();
        }
        if (Panel1.activeSelf == true && done == false)
        {
            increasescore();
        }
        if (q1.activeSelf == true && done == true)
        {
            done = false;
        }
        if (q2.activeSelf == true && done == true)
        {
            done = false;
        }
        if (q3.activeSelf == true && done == true)
        {
            done = false;
        }

        showscore.text = totalscore.ToString()+" / 3";
       
    }

    void increasescore()
    {
        totalscore += 1;
        done = true;
    }
}
