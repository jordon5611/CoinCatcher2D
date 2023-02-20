using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody2D rb;
    Player_Movement Pm;
    public GameObject BulletPrefab;
    float sign;
    // Start is called before the first frame update
    void Start()
    {
        Pm = FindObjectOfType<Player_Movement>();
        rb = GetComponent<Rigidbody2D>();
        sign = Pm.transform.localScale.x;
    }
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {

        rb.velocity = transform.right * speed * -sign;

        if (transform.position.x < -8.62)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > 12.14) {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy" || collision.gameObject.name == "Enemy1") {

            Destroy(collision.gameObject);
        }
    }
}
