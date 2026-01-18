using UnityEngine;

public class MovingTilemap : MonoBehaviour
{
    public float speed = 2f;
    public float height = 3f;

    private Rigidbody2D rb;
    private Vector2 startPos;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = rb.position;
    }

    void FixedUpdate()
    {
        float y = Mathf.Sin(Time.time * speed) * height;
        rb.MovePosition(startPos + Vector2.up * y);
    }
}
