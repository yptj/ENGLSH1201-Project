using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint;

    public void Respawn()
    {
        transform.position = respawnPoint.position;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}