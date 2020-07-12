using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enenmy : MonoBehaviour
{


    public float speed;
    public float distance;
    private bool moveright;
    public Transform platformdetector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D hit = Physics2D.Raycast(platformdetector.position, Vector2.down, distance);
        if(hit.collider==false)
        {
            if (moveright)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveright = true;
            }
        }
    }
    
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }*/
}
