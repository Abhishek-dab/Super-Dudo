using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public RepositionDelay repositiondelay;
    public int scorevalue;
    // Start is called before the first frame update
    void Start()
    {
        repositiondelay = FindObjectOfType < RepositionDelay>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up * 2);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Sounds.Playmusic("Coins");
            repositiondelay.Addscore();
            Destroy(gameObject);
            
        }
        
        
    }
}
