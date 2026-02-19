using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 7f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal"); // A/D or ←/→
        rb.linearVelocity = new Vector2(x * moveSpeed, rb.linearVelocity.y);
    }
}
