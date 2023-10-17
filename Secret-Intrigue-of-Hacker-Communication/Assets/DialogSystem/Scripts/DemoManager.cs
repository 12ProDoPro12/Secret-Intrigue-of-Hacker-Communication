using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour
{
    [SerializeField] private GameObject dialogBtn;
    public void HideDialogButton()
    {
        dialogBtn.SetActive(false);
    }
}
