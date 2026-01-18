using TMPro;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class TypeWriterEffect : MonoBehaviour
{
    public TMP_Text textUI;
    public float typingSpeed = 0.05f;
    private GameManager gameManager;
    private string fullText;

    [SerializeField]
    private bool Vanish = false;
    void Start()
    {
        fullText = textUI.text;   // 원래 텍스트 저장
        textUI.text = fullText;
        textUI.maxVisibleCharacters = 0;
        gameManager = FindAnyObjectByType<GameManager>();
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            textUI.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typingSpeed);
            gameManager.TypeSoundPlay();
        }
        if (Vanish == true)
        {
            yield return new WaitForSeconds(6f);
            textUI.maxVisibleCharacters = 0;
        }
    }
    
}
