using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private float currentSpeed;

    public Transform paddle;
    public Rigidbody2D rb;
    private bool isLaunch = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void Update()
    {
        if (!isLaunch)
        {
            transform.position = paddle.position + Vector3.up * 0.5f;

            if (Input.GetMouseButtonDown(0))
            {
                Launch();
            }
        }
    }

    void Launch()
    {
        isLaunch = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
        currentSpeed = speed;

        Vector2 dir = new Vector2(Random.Range(-0.5f, 0.5f), 1f);
        rb.linearVelocity = dir * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            //Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Paddle"))
        {
            float paddleWidth = collision.collider.bounds.size.x;
            float offset = transform.position.x - collision.transform.position.x;
            float normalized = offset / (paddleWidth / 2);

            Vector2 dir = new Vector2(normalized, 1f).normalized;

            Rigidbody2D paddleRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (paddleRb != null)
            {
                dir.x = paddleRb.position.x * 0.2f;
            }

            currentSpeed += 0.1f;
            rb.linearVelocity = dir.normalized * currentSpeed;
        }
    }
}
