using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float starttime;
    private float actualtime =0;
    //public Text countdown;
    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        actualtime = starttime;

    }

    // Update is called once per frame
    void Update()
    {
        actualtime -= 1 * Time.deltaTime;
        countdown.text = "Timer: " + actualtime.ToString("0");
        if(actualtime<=0)
        {
            actualtime = 0;
        }
        if (actualtime <= 5)
        {
            countdown.color = Color.red;
        }
        if (actualtime == 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
