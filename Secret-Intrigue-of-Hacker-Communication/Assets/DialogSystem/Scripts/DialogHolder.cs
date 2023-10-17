using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    [SerializeField] private Dialog dialog;

    private DialogController dialogUI;

    private void Awake()
    {
        GameObject dialogObj = GameObject.FindGameObjectWithTag("Dialog");

        if(dialogObj)
        {
            dialogUI = dialogObj.GetComponent<DialogController>();
        }
        else
        {
            Debug.Log("Не найден объект с тэгом Dialog!");
        }
    }

    public void Trigger()
    {
        if(dialogUI)
        {
            dialogUI.ShowDialog(dialog);
        }
        else
        {
            Debug.Log("Не найден объект с тэгом Dialog!");
        }
    }
}
