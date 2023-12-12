using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class gonextbutton : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onpress;
    public UnityEvent onrelease;
    public GameObject righthand;
    public GameObject lefthand;
    bool isPressed;
    public watertemN watertemN;
    public watertemS watertemS;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        watertemN = FindObjectOfType<watertemN>();
        watertemS = FindObjectOfType<watertemS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            if (other.gameObject == righthand|| other.gameObject == lefthand)
            {
                Debug.Log("hello");
                button.transform.localPosition = new Vector3(0, -0.3f, 0);
                isPressed = true;
            }
            
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == righthand || other.gameObject == lefthand)
        {
            Debug.Log("i'm out");
            button.transform.localPosition = new Vector3(0, -0.1f, 0);
            onrelease.Invoke();
            isPressed = false;
        }
    }

    public void nextscrean()
    {
        if (watertemN.tem>=95 == true&& watertemS.tem>=95)
        {
            Debug.Log("gonext");
            SceneManager.LoadScene("QuizStage2");
        }
        else
        {
            Debug.Log("net finish yet");
        }
    }


    public IEnumerator Wait()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        panel.SetActive(false);
    }

    public void showpanel()
    {
        if(watertemN.tem <= 95 == true && watertemS.tem <= 95)
        {
            StartCoroutine(Wait());
        }
        
    }
}
