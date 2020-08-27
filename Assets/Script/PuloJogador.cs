using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloJogador : MonoBehaviour
{

    public Rigidbody2D rb;

    public float forcaPulo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * forcaPulo);
        }
    }
}
