using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{    public bool isplayer1;
     public float speed;
     public Rigidbody2D rb;


    private float mouvement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isplayer1)
        {
            mouvement = Input.GetAxisRaw("Vertical");

        }
        else
        {
            mouvement = Input.GetAxisRaw("Vertical 2");
        }
        rb.velocity = new Vector2(rb.velocity.x, mouvement * speed);
    }
}
