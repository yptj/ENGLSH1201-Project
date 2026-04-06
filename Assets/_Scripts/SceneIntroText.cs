using UnityEngine;
using TMPro;
using System.Collections;

public class SceneIntroText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI introText;
    [SerializeField] private float showDuration = 2.5f;

    private void Start()
    {
        StartCoroutine(ShowIntro());
    }

    private IEnumerator ShowIntro()
    {
        introText.gameObject.SetActive(true);
        yield return new WaitForSeconds(showDuration);
        introText.gameObject.SetActive(false);
    }
}
