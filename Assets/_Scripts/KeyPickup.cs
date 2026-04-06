using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private string nextSceneName = "VictoryScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
