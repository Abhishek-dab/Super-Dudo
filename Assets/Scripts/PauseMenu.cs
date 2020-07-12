using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu, pausebutton;
    public void Pause()
    {
        pausemenu.SetActive(true);
        pausebutton.SetActive(false);
        Time.timeScale = 0;

    }
    public void Resume()
    {
        pausemenu.SetActive(false);
        pausebutton.SetActive(true);
        Time.timeScale = 1;

    }

}
