using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Transform playerpos;
    Animator anim;
    public Sprite midjump;
    public Sprite sliding;
    private SpriteRenderer actualsprite;
    public GameObject mainchar;
    bool righttrue;
    bool onawall;
    public int playerhp = 3;
    public GameObject hitwallparticle;

    // Start is called before the first frame update
    void Start()
    {
        actualsprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerpos = GetComponent<Transform>();
        righttrue = false;
        onawall = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (onawall)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {

                if (righttrue)
                {
                    righttrue = false;
                }
                else
                {
                    righttrue = true;
                }
                mainchar.GetComponent<Animator>().enabled = false;
                mainchar.GetComponent<Animator>().enabled = true;
                mainchar.GetComponent<Animator>().Rebind();
                anim.SetBool("pressed", true);
                dothejump();
                onawall = false;
            }
        }
        else
        {
            //THIS BITCH EMPTYYY
        }



    }

    void dothejump()
    {

        if (righttrue)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);

        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        
        onawall = true;
        // if (collision.gameObject.name == "top left"|| "center left"||"bottom left"|| "top right" || "center right" || "bottom right" ||)
        if (col.gameObject.tag == "wall")
        {

            mainchar.GetComponent<Animator>().enabled = false;
            anim.SetBool("pressed", false);
            mainchar.GetComponent<Animator>().enabled = true;

            anim.SetBool("Arriving", true);
            rb.velocity = new Vector2(0, 0);
            Vector3 AScale = transform.localScale;
            Vector3 Apos = transform.localPosition;

            if (righttrue)
            {
                Apos.y = 250;
                Apos.x = 128;
                AScale.x = -3;
                transform.localScale = AScale;
                transform.localPosition = Apos / 100;
                /*
                Vector3 particleposition = new Vector3(100, 250, 0);
                Instantiate(hitwallparticle, particleposition, Quaternion.identity);
                */
            }
            else
            {

                Apos.y = 250;
                Apos.x = -122;
                AScale.x = 3;
                transform.localScale = AScale;
                transform.localPosition = Apos / 100;
               /* Vector3 particleposition = new Vector3(-100, 250, 0);
                Instantiate(hitwallparticle, particleposition, Quaternion.identity);
                */

            }
        }

    }

    }



    //********************************************************
    
