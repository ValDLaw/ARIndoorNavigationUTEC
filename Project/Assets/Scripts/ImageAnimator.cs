using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public float typingSpeed = 0.05f;
    public string fullText = "La forma más fácil de ubicarte en UTEC";

    void Start()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        while (true)
        {
            titleText.text = "";
            foreach (char c in fullText)
            {
                titleText.text += c;
                yield return new WaitForSeconds(typingSpeed);
            }
            yield return new WaitForSeconds(2.0f); // Wait for a bit before restarting
        }
    }
}
