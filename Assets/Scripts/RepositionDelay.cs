using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RepositionDelay : MonoBehaviour
{
    public float repositiondelay;
    public PlayerMovement playermove;
    public int score =0;
    public Text wintext;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        playermove = FindObjectOfType<PlayerMovement>();
        ScoreText.text = "Score: " + score;
        wintext.text = "";
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void Delay()
    {
        StartCoroutine("RepositionCoroutine");
    }
    public IEnumerator RepositionCoroutine()
    {
        playermove.gameObject.SetActive(false);
        yield return new WaitForSeconds(repositiondelay);
        playermove.transform.position = playermove.spawnsprite;
        playermove.gameObject.SetActive(true);
    }
    public void Addscore()
    {
        score = score+1;
        ScoreText.text = "Score: " + score;
        if (score == 7)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
