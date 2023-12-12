using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using UnityEngine;

public class timetest : MonoBehaviour
{
    public int minutes;
    public int seound;
    private float timer = 0.0f;
    float starttime;
    public TMP_Text text;
    public TextMeshProUGUI resulttext;
    public bool timestamp;
    

    // Start is called before the first frame update
    void Start()
    {
       timestamp = false;
        starttime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;              
        minutes = Mathf.FloorToInt(timer / 60f);
        seound = Mathf.FloorToInt(timer - minutes *60);
        text.text = string.Format("{0:00}:{1:00}", minutes, seound);
        


    }
}
