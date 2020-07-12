using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{   public static AudioClip playerhit, enemydestroy, jump, coinscollection;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        playerhit = Resources.Load<AudioClip>("PlayerHit");
        enemydestroy = Resources.Load<AudioClip>("EnemyDestroyed");
        jump = Resources.Load<AudioClip>("Jump");
        coinscollection = Resources.Load<AudioClip>("Coins");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playmusic(string clip)
    {
        switch (clip)
        {
            case "PlayerHit":
                audiosrc.PlayOneShot(playerhit);
                break;
            case "EnemyDestroyed":
                audiosrc.PlayOneShot(enemydestroy);
                break;
            case "Jump":
                audiosrc.PlayOneShot(jump);
                break;
            case "Coins":
                audiosrc.PlayOneShot(coinscollection);
                break;

        }

    }
}
