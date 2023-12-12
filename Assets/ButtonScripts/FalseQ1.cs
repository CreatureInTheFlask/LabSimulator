using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseQ1 : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public void OpenPanel()
    {
       
        if(Panel != null || Panel2 !=null)
        {
           
            bool isActive = Panel.activeSelf;
            bool Close = Panel2.activeSelf;
            Panel.SetActive(!isActive);
            Panel2.SetActive(!Close);
        }
    }

}
