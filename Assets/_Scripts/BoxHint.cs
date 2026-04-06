using UnityEngine;

public class BoxHintTrigger : MonoBehaviour
{
    [SerializeField] private GameObject pressEText;
    [SerializeField] private GameObject arrowHint;

    private bool playerNearby = false;
    private bool hasShown = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasShown && other.CompareTag("Player"))
        {
            playerNearby = true;
            pressEText.SetActive(true);
            arrowHint.SetActive(true);
            hasShown = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }

    private void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            pressEText.SetActive(false);
            arrowHint.SetActive(false);
        }
    }
}