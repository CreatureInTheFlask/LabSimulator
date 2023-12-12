using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class timec : MonoBehaviour
{
    public Toggle q1, q2, q3, q4, q5, q6;
    bool end1, end2, end3, end4, end5, end6;
    public float timeStart;
 //   public Text textBox;
   
    public static bool activityIsActive = true;
    [SerializeField] TextMeshProUGUI m_Object;
    public TMP_Text textbox1, textbox2, textbox3, textbox4, textbox5, textbox6;

    void Start()
    {
       
        
        end1 = false;
        end2 = false;
        end3 = false;
        end4 = false;
        end5 = false;
        end6 = false;
    }
    // Start is called before the first frame update
    /*  void Start()
      {
          textBox = GetComponent<Text>();
          textbox2 = GetComponent<TextMeshProUGUI>();

          textBox.text = timeStart.ToString("F2");
          textbox2.text = timeStart.ToString("F2");
      }*/

    // Update is called once per frame
    void Update()
    {
        switch (activityIsActive)
        {
            case true:
                timeStart +=Time.deltaTime;
                // textBox.text = timeStart.ToString("F2");
                m_Object.text = timeStart.ToString("F0");
               
                break;

            case false:
                break;

            default:
        }
        addtime();
      

    }

    void addtime() {
        if (q1.GetComponent<Toggle>().isOn == true&&end1==false)
        {

            Debug.Log("dd");
            textbox1.text += "   "+m_Object.text + " S";
            end1 = true;

        }
        if (q2.GetComponent<Toggle>().isOn == true && end2 == false)
        {
            textbox2.text += "   " + m_Object.text + " S";
            end2 = true;

        }
        if (q3.GetComponent<Toggle>().isOn == true && end3 == false)
        {
            textbox3.text += "   " + m_Object.text + " S";
            end3 = true;

        }
        if (q4.GetComponent<Toggle>().isOn == true && end4 == false)
        {
            textbox4.text += "   " + m_Object.text + " S";
            end4 = true;

        }
        if (q5.GetComponent<Toggle>().isOn == true && end5 == false)
        {
            textbox5.text += "   " + m_Object.text + " S";
            end5 = true;

        }
        if (q6.GetComponent<Toggle>().isOn == true && end6 == false)
        {
            textbox6.text += "   " + m_Object.text+" S";
            end6 = true;

        }

    }


}
