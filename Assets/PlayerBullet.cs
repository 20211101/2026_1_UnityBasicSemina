using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    
}
