//this is the ball script
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 30;

    // Start is called before the first frame update
    void Start(){
    
    //initial velocity
    GetComponent<Rigidbody2D>().velocity = Vector2.right* speed;
    }
        
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
