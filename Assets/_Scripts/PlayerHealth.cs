using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public TextMeshProUGUI healthText;

    private bool isInvincible = false;
    public float invincibleDuration = 1f;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        if (isInvincible) return;

        currentHealth -= amount;

        if (currentHealth < 0)
            currentHealth = 0;

        UpdateHealthUI();
        StartCoroutine(Invincibility());

        if (currentHealth <= 0)
        {
            Debug.Log("Player died");

            PlayerRespawn respawn = GetComponent<PlayerRespawn>();
            if (respawn != null)
            {
                respawn.Respawn();
            }

            currentHealth = maxHealth;
            UpdateHealthUI();
        }
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "HP: " + currentHealth;
        }
    }

    IEnumerator Invincibility()
    {
        isInvincible = true;
        yield return new WaitForSeconds(invincibleDuration);
        isInvincible = false;
    }
}