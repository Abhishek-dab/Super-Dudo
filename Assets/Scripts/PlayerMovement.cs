using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    private float move = 0f;
    private Rigidbody2D rig;
    public Vector3 spawnsprite;
    public RepositionDelay repositiondelay;
    public GameObject bullet;
    Vector2 bullpos;
    bool face_right = true;
    public float firerate = 0.05f;
    public float nextfire = 0.0f;
    public GameObject bullet1;
    public GameObject blood;
    public GameObject bloo;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spawnsprite = transform.position;
        repositiondelay = FindObjectOfType<RepositionDelay>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (move > 0f)
        {
            face_right = true;
            rig.velocity = new Vector2(move * speed, rig.velocity.y);
            transform.localScale = new Vector2(1.09099f, 1f);
        }
        else if (move < 0f)
        {
            face_right = false;
            rig.velocity = new Vector2(move * speed, rig.velocity.y);
            transform.localScale = new Vector2(-1.09099f, 1f);//if moves back 180 shift.
        }
        else
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            Sounds.Playmusic("Jump");
            rig.velocity = new Vector2(rig.velocity.x, jumpspeed);
        }

        if (Input.GetButton("Fire1") && Time.time > nextfire)
        {

            nextfire = Time.time + firerate;
            Fire();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Falldetector")
        {
            repositiondelay.Delay();
        }
        if (collision.tag == "Checkpoint")
        {
            spawnsprite = collision.transform.position;
        }
        if (collision.tag == "heart")
        {
            Instantiate(blood, transform.position, Quaternion.identity);

        }
        if(collision.tag == "Enemy")
        {
            Instantiate(bloo, transform.position, Quaternion.identity);
        }
    }

    void Fire()
    {
        bullpos = transform.position;
        if (face_right)
        {
            bullpos += new Vector2(1f, -0.43f);
            Instantiate(bullet, bullpos, Quaternion.identity);
        }
        else
        {
            bullpos += new Vector2(-1f, -0.43f);
            Instantiate(bullet1, bullpos, Quaternion.identity);
        }
        
    }
}