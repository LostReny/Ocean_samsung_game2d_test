using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour

{

    public Rigidbody2D rb;

    public float velocidade = 1;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");

        /*Seta para a direita, valor do h vai até 1, somando um pouco a cada frame
        Seta para esquerda, valor do h vai até -1, diminuindo um pouco a cada frame */

        // Movimentação do Jogador
        rb.velocity = new Vector2(h * velocidade, rb.velocity.y);

        //Apontar para direção do movimento
        if (h > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }

        else if (h < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Andando", true);
        }
        else
        {
            anim.SetBool("Andando", false);
        }

        anim.SetBool("Andando", Mathf.Abs(rb.velocity.x) > 0);


    }
}
