using UnityEngine;

public class PressTile : MonoBehaviour
{
    public float pressedY = 0.1f;
    public float speed = 8f;

    Vector3 originPos;
    bool isPressed = false;

    void Start()
    {
        originPos = transform.localPosition;
    }

    void Update()
    {
        Vector3 target = isPressed
            ? originPos + Vector3.down * pressedY
            : originPos;

        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            target,
            Time.deltaTime * speed
        );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isPressed = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isPressed = false;
    }
}
