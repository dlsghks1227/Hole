using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMainMenu : MonoBehaviour
{
    private void Start()
    {
    }
    public void OnButtonStart()
    {
        SceneManager.LoadScene("Day_1_Game");
    }
    public void OnButtonExit()
    {
        Application.Quit();
    }
}
