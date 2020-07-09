using UnityEngine;

public class firstgame : MonoBehaviour
{
    private float speed = 5f;
    public string axisName;
    public Rigidbody2D rb;

    //update - fixedupdate - star
   void Update()
    {
        float y = Input.GetAxisRaw(axisName);
    rb.velocity = new Vector2(0, y) * speed;
    }
}
