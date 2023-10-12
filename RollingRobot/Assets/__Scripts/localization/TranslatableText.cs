using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TranslatableText : MonoBehaviour
{
    public int textID;
    [HideInInspector] public TextMeshProUGUI UIText;

    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
        Translator.Add(this);
    }
    private void Start()
    {
        Translator.UpdateTexts();// сделать только для этого текста, или один общий вызов. 
    }
    private void OnDestroy()
    {
        Translator.Remove(this);
    }
}
