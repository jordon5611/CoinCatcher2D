using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public float speed = 1.7f;
    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        



    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        speed = -speed;
        transform.localScale = new Vector2(-1 * transform.localScale.x, transform.localScale.y);

    }



}
