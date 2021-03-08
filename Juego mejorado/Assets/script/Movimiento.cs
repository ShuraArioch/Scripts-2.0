using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocity = 5.0f;
    public float jumpForce = 600;
    public float falMultiplier = .05f;
    public float lowMultiplier = 1f;
    public bool betterJump = false;
    public float inputValue;
    //public GameManager Salida; esto es de otra claasse que requiere para funcionar

    public LayerMask layerOfFloor;
    public Transform checkFloor;

    bool onFloor;

    Animator animationn;

    Rigidbody2D rigidBody;

    Vector3 principalScale;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        principalScale = transform.localScale;
        animationn = GetComponent<Animator>();
    }

    public void getInput()
    {
        inputValue = Input.GetAxis("Horizontal") * velocity;
    }
    public void movePlayer()
    {
        
        rigidBody.velocity = new Vector2(inputValue, rigidBody.velocity.y);

        if (rigidBody.velocity.x > 0)
        {
            transform.localScale = principalScale;
        }

        else if (rigidBody.velocity.x < 0)
        {
            transform.localScale = new Vector3(-principalScale.x, principalScale.y, principalScale.z);
        }
    }
    public void animatePlayer()
    {
        if (inputValue != 0)
        {
            animationn.SetBool("Run", true);
        }
        else
        {
            animationn.SetBool("Run", false);
        }
        animationn.SetBool("onFloor", onFloor);
    }
    public void getInputJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rigidBody.AddForce(Vector2.up * jumpForce);
            animationn.SetTrigger("Jump");
        }
    }
    public void jump()
    {
        if (betterJump)
        {
            if (rigidBody.velocity.y < 0)
            {
                rigidBody.velocity += Vector2.up * Physics2D.gravity.y * (falMultiplier) * Time.deltaTime;
            }
            if (rigidBody.velocity.y > 0 && !Input.GetKey("space"))
            {
                rigidBody.velocity += Vector2.up * Physics2D.gravity.y * (lowMultiplier) * Time.deltaTime;
            }
        }
    }
    private void Update() 
    {
        getInputJump();
        getInput();

    }

    private void FixedUpdate()

    {
        jump();
        movePlayer();
        animatePlayer();
        onFloor = Physics2D.OverlapCircle(checkFloor.position, 0.1f, layerOfFloor);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Exit"))
        {
           // Salida.Salir(); igual requiere de otra clase para funcionar
        }
    }



}
