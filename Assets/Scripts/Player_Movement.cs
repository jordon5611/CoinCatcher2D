using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator Anim;
    BoxCollider2D Bc;
    public GameObject BulletPrefab;

    public TimeLeft TL;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        Bc = GetComponent<BoxCollider2D>();
        TL = FindObjectOfType<TimeLeft>();

    }

    // Update is called once per frame
    public float JumpHeight = 3f;
    public float speed = 2f;
    float dirX = 0;
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed,rb.velocity.y);
        
        
        if(Input.GetButtonDown("Jump")){
            if (Bc.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                rb.AddForce(Vector2.up * JumpHeight, ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown("v"))
        { //FIRE


            if (transform.localScale.x > 0)
            {
                
                Instantiate(BulletPrefab, transform.position + new Vector3(-0.5f, 0, 0), transform.rotation);

            }
            else if (transform.localScale.x < 0)
            {

                Instantiate(BulletPrefab, transform.position + new Vector3(0.5f, 0, 0), transform.rotation);

            }


        }


        if (dirX > 0f )
        {
            Anim.SetBool("moving", true);
            transform.localScale = new Vector3(-0.983f, transform.localScale.y, transform.localScale.z);
            

        } else if (dirX < 0f) {

            Anim.SetBool("moving", true);
            transform.localScale = new Vector3(0.983f, transform.localScale.y, transform.localScale.z);
            
        }
        else {
            Anim.SetBool("moving", false);
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Enemy"|| col.gameObject.name == "Enemy1")
        {
            Destroy(gameObject);
            TL.GameOverFun();
            //GameOver
        }

        
    }
}
