using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{
    [SerializeField] private GameObject dialogUI;
    [SerializeField] private GameObject textContainer;
    [SerializeField] private GameObject buttonsContainer;

    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private List<DialogAnswerUI> dialogAnswersUI;

    private Dialog currentDialog;
    private int textPartIndex;

    public void ShowDialog(Dialog dialog)
    {
        dialogUI.SetActive(true);
        textContainer.SetActive(true);


        currentDialog = dialog;
        textPartIndex = 0;
        dialogText.text = currentDialog.textParts[textPartIndex];
    }

    public void NextTextPart()
    {
        textPartIndex += 1;

        if(textPartIndex < currentDialog.textParts.Count)
        {
            dialogText.text = currentDialog.textParts[textPartIndex];
        }
        else
        {
            if (currentDialog.dialogAnswer.Count > 0)
            {
                ShowVariantBtns();
            }
            else
            {
                if(currentDialog.signal)
                {
                    currentDialog.signal.Call();
                }
                dialogUI.SetActive(false);
            }
        }
    }

    public void ChooseVariant(DialogAnswer variant)
    {
        foreach(DialogAnswerUI answerUI in dialogAnswersUI)
        {
            answerUI.gameObject.SetActive(false);
        }

        buttonsContainer.SetActive(false);

        if(variant.signal)
        {
            variant.signal.Call();
        }

        if (variant.nextDialog)
        {
            ShowDialog(variant.nextDialog);
        }
        else
        {
            dialogUI.SetActive(false);
        }
    }

    private void ShowVariantBtns()
    {
        textContainer.SetActive(false);
        buttonsContainer.SetActive(true);

        for (int i = 0; i < currentDialog.dialogAnswer.Count; i++)
        {
            dialogAnswersUI[i].gameObject.SetActive(true);
            dialogAnswersUI[i].Show(currentDialog.dialogAnswer[i]);
        }
    }
}
