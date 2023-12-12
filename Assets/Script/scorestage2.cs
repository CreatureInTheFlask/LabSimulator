using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorestage2 : MonoBehaviour
{
  //  Stage2Quizz stage2Quizz;
    public TMP_Text text;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
       // stage2Quizz = FindObjectOfType<Stage2Quizz>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString()+" / 7 ";
        
    }
    public void increasescore()
    {
        Debug.Log("scoreincrese");
        score = score + 1;
    }
}
