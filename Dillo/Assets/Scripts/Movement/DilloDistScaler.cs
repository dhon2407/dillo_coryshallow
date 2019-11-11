using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* D I S T A N C E 
                   S C A L E R 

public class DilloDistScaler : MonoBehaviour
{
    //values
    public float distB; //distance from bottom
    public float distT; //distance from top

    private Vector2 vert; //vertical location
    private SpriteRenderer spriteRenderer;



         void Start()
          {          
           rb = GetComponent<Rigidbody2D>();   //calls the rigidbody as 'rb'
          }

         void Awake()
          {
          spriteRenderer = GetComponent<SpriteRenderer>(); //calls the spriterenderer
          }


    void CoordinateDillo()
    {
        Vector2 vert = Vector2.zero;
        vert.y = Input.GetAxis("Vertical");
        distB = (-5 + vert.y); 
        distT = (-0.46 - vert.y); 
    }

    void Update()
    {
        boolDistanceUp = (rb.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); ) ? ();
        { }
    }
        
} // DilloDistScaler class

    */