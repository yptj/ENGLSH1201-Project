using UnityEngine;
using TMPro;
using System.Collections;

public class IntroTextFade : MonoBehaviour
{
    public float displayTime = 2f;
    public float fadeDuration = 1f;

    private TextMeshProUGUI textUI;

    void Start()
    {
        textUI = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        // 先停留
        yield return new WaitForSeconds(displayTime);

        float t = 0;
        Color originalColor = textUI.color;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float alpha = 1 - (t / fadeDuration);

            textUI.color = new Color(
                originalColor.r,
                originalColor.g,
                originalColor.b,
                alpha
            );

            yield return null;
        }

        gameObject.SetActive(false);
    }
}