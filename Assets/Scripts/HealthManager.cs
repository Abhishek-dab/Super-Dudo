using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public GameObject heartno1, heartno2, heartno3;
    public static int health;
    

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heartno1.gameObject.SetActive(false);
        heartno2.gameObject.SetActive(false);
        heartno3.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
      
        if (health > 3)
            health = 3;
        switch (health)
        { 
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heartno3.gameObject.SetActive(true);



                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heartno2.gameObject.SetActive(true);
                heartno3.gameObject.SetActive(true);

                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heartno1.gameObject.SetActive(true);
                heartno2.gameObject.SetActive(true);
                heartno3.gameObject.SetActive(true);
              
               SceneManager.LoadScene("LoseScene");
                break;
        }
    }
}
