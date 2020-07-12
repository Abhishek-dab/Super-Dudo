using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 positionplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionplayer = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        if (player.transform.localScale.x>0f)
        {
            positionplayer = new Vector3(positionplayer.x + offset, positionplayer.y, positionplayer.z);
        }
        else
        {
            positionplayer = new Vector3(positionplayer.x - offset, positionplayer.y, positionplayer.z);
        }
        transform.position = positionplayer;
    }
    
}
