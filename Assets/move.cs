using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float force;
    float x;
    public Animator animJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * force * speed);
            animJump.Play("Jump");
        }

        x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * Time.deltaTime * speed;

        if(x !=0 )
        {
            animJump.Play("Walk");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            animJump.Play("attack");
        }
    }
}
