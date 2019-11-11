using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DilloMovementScript : MonoBehaviour
{
  
    
    //solid
    public float speed;
    
    
    //identities
    private Rigidbody2D rb;
    private Vector2 mv;
    private SpriteRenderer spriteRenderer;



    void Start()
    {
       //calls the rigidbody as 'rb'
        rb = GetComponent<Rigidbody2D>();
       
    }

    void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void ComputeVelocity()
    {
        Vector2 mv = Vector2.zero;

        mv.x = Input.GetAxis("Horizontal");
    }

        void Update()
    {
        //normal movement x & y
        Vector2 mi = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mv = mi.normalized * speed;

        //current spriteflip bool
        bool flipSprite = (spriteRenderer.flipX ? (mv.x > 0.00f) : (mv.x < 0.00f));

        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        else flipSprite = false;

        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 2f) * -1;
        // LAYER SORTING ORDER METHOD
        // Need to transfer this to the array of layers

    }

    private void FixedUpdate()
    {
        //smooths the movement of the rigidbody over time 
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
        
       
      
    }
    
    }
