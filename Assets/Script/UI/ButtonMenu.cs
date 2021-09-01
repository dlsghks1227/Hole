using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public FadeController fader;
    public AudioClip playerdiesound;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        AudioSource.PlayClipAtPoint(playerdiesound, new Vector3(0.0f, 0.0f, 0.0f));
        fader.FadeIn(2.0f);
    }

    public void OnButtonMenu()
    {
        fader.FadeIn(3.0f, () => { SceneManager.LoadScene("Menu"); });
    }
}
