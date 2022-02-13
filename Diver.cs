using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diver : MonoBehaviour
{
    Rigidbody2D rb; 

    bool isJumping;
    // Start is called before the first frame update
    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update( )
    {
        if(Input.GetKey("space") && isJumping == false){
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "obstacle") 
        {
            gameManager.GameOver();
        }
    }
}
