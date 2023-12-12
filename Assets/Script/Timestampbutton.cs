using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Timestampbutton : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onpress;
    public UnityEvent onrelease;
    public GameObject righthand;
    public GameObject lefthand;
    bool isPressed;
    public TMP_Text resulttime,resulttem;
    public int minutes;
    public int seound;
    private float timer = 0.0f;
    public watertemN watertemN;
    public watertemS watertemS;
    public TMP_Text text;
    private bool starttime;
    public Toggle toggle;
    private bool canaddtext;
    public GameObject wholesalt;
    public GameObject saltcanva;
    public AudioClip soundClip;
    public AudioClip fourminpast;
    public AudioClip finish;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        starttime = false;
        watertemN = FindObjectOfType<watertemN>();
        watertemS = FindObjectOfType<watertemS>();
        toggle.GetComponent<Toggle>();
        canaddtext = true;
        wholesalt.SetActive(false);
        saltcanva.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
    }

    // Update is called once per frame
    void Update()
    {
        starttimer();
        if (toggle.isOn)
        {
            starttime = true;
        }
        if(minutes == 10)
        {
            wholesalt.SetActive(true);
            saltcanva.SetActive(true);
        }
        if (minutes == 0 && seound == 3)
        {
            audioSource.Play();
        }
        if (minutes == 4 && seound == 1)
        {
            audioSource.clip = fourminpast;
            audioSource.Play();
        }
        if (minutes == 9 && seound == 55)
        {
            audioSource.clip = finish;
            audioSource.Play();
        }
       
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            if (other.gameObject == righthand || other.gameObject == lefthand)
            {
               
                button.transform.localPosition = new Vector3(0, 100f, 0);
                isPressed = true;
            }


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == righthand || other.gameObject == lefthand)
        {
            
            button.transform.localPosition = new Vector3(0, 115f, 0);
            if (seound > 0)
            {
            onrelease.Invoke();
            }
            
            isPressed = false;
        }
    }

    public void appendtext()
    {
        if(canaddtext==true&&minutes<=10)
        {
            resulttime.text += text.text + "\n";
            resulttem.text += watertemN.tem.ToString() + "\n";
            canaddtext=false;
            StartCoroutine(Wait());
        }
        
        

    }
    public void appendtextWaters()
    {
        resulttime.text += text.text + "\n";
        resulttem.text += watertemS.tem.ToString() + "\n";
    }

    public void starttimer()
    {
        if (starttime == true && minutes <=10)
        {
            timer += Time.deltaTime*3;
            minutes = Mathf.FloorToInt(timer / 60f);
            seound = Mathf.FloorToInt(timer - minutes * 60);
            text.text = string.Format("{0:00}:{1:00}", minutes, seound);
            appendtext();

        }
       
    }

    public IEnumerator Wait()
    {
        if (starttime == true)
        {
            yield return new WaitForSeconds(30.0f);
            appendtext();
            canaddtext = true;
        }
       
    }

    public void resettime()
    {
        starttime = false;
        resulttime.text = "";
        resulttem.text = "";
        seound = 0;
        minutes = 0;
        timer = 0;
        canaddtext = true;
    }

}

