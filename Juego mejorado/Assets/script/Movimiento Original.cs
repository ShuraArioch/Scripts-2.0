/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float vel = 5.0f;
    public float fuerzaSalto = 600;
    public float falMultiplier = .05f;
    public float lowMultiplier = 1f;
    public bool betterJump = false;
    public GameManager Salida;

    public LayerMask capaSuelo;
    public Transform checkSuelo;

    bool enSuelo;

    Animator anim;

    Rigidbody2D rb;

    Vector3 escalaPric;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        escalaPric = transform.localScale;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * vel;
        rb.velocity = new Vector2(h, rb.velocity.y);

        if (rb.velocity.x > 0)
        {
            transform.localScale = escalaPric;
        }

        else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-escalaPric.x, escalaPric.y, escalaPric.z);
        }

        //Animation

        if (h != 0)
        {
            anim.SetBool("Correr", true);
        }
        else
        {
            anim.SetBool("Correr", false);
        }
        anim.SetBool("enSuelo", enSuelo);


        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector2.up * fuerzaSalto);
            anim.SetTrigger("Saltar");
        }

        //mejora de salto
        if (betterJump)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (falMultiplier) * Time.deltaTime;
            }
            if (rb.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowMultiplier) * Time.deltaTime;
            }
        }
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(checkSuelo.position, 0.1f, capaSuelo);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Salida"))
        {
            Salida.Salir();
        }
    }



}*/