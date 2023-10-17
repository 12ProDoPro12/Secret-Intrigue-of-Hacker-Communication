using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class DialogAnswerUI : MonoBehaviour
{
    [SerializeField] private UnityEvent<DialogAnswer> OnChoose;

    private TextMeshProUGUI btnText;
    private DialogAnswer currentAnswer;

    public void ChooseVariant()
    {
        OnChoose.Invoke(currentAnswer);
    }

    public void Show(DialogAnswer answer)
    {
        currentAnswer = answer;

        if(!btnText)
        {
            btnText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        }

        btnText.text = currentAnswer.text;
    }
}
