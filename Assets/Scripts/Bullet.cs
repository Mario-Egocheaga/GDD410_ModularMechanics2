using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = .5f;
    private void Update()
    {
        if (!Pause.paused)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
        }
        else
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Delete")
        {
            Destroy(gameObject);
        }
    }
}
