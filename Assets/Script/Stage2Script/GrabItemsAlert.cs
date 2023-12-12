using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabItemsAlert : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle1, toggle2, toggle3, toggle4;

    public GameObject panel;
    
    public AudioClip myAudioClip;
    private AudioSource audioSource;
    
    void Start()
    {                                
       
        panel.SetActive(false);
        audioSource = GetComponent<AudioSource>();   
        audioSource.clip = myAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void unfinish1()
    {
        if (toggle1.GetComponent<Toggle>().isOn == false)
        {
            panel.SetActive(true);
            audioSource.Play();
        }
    }
    public void unfinish2()
    {
        if (toggle2.GetComponent<Toggle>().isOn == false)
        {
            panel.SetActive(true);
            audioSource.Play();
        }
    }
    public void unfinish3()
    {
        if (toggle3.GetComponent<Toggle>().isOn == false)
        {
            panel.SetActive(true);
            audioSource.Play();
        }
    }
    public void unfinish4()
    {
        if (toggle4.GetComponent<Toggle>().isOn == false)
        {
            panel.SetActive(true);
            audioSource.Play();
        }
    }

    public void ungrab()
    {
      panel.SetActive(false);
    }
}
