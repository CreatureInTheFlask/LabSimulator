using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBtn : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
