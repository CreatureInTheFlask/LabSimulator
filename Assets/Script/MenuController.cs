using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] RectTransform fader;
    public Toggle combine;

    private void Start()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setOnComplete(() =>
        {
             fader.gameObject.SetActive(false);
        
        });
    }
    
    public void StartBtn()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero,0f);
        LeanTween.scale(fader, new Vector3(1,1,1),0.5f).setOnComplete(() =>
        {
            // fader.gameObject.SetActive(false);
            SceneManager.LoadScene("lab1");
        });
      
    }
    public void MainmenuBtn()
    {

        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() =>
        {
            // fader.gameObject.SetActive(false);
            SceneManager.LoadScene("Oldmenu");
        });
    }

    public void backtomenu()
    {
        SceneManager.LoadScene("Oldmenu");
    }

    public void gostage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void gostage1()
    {
        SceneManager.LoadScene("lab1");
    }
    public void gostage1part2()
    {
        SceneManager.LoadScene("lab1part2");
    }
    public void goQuizStage2()
    {
        SceneManager.LoadScene("QuizStage2");
    }

    public void labpart2()
    {
      
        if (combine.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("in");
            float curtime = 0;
               curtime +=Time.deltaTime;
            Debug.Log(curtime);
            if (curtime > 7f)
            {


                fader.gameObject.SetActive(true);
                LeanTween.scale(fader, Vector3.zero, 0f);
                LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() =>
                {
                    // fader.gameObject.SetActive(false);
                    SceneManager.LoadScene("lab1part2");
                });
            }
        }
    }
}
