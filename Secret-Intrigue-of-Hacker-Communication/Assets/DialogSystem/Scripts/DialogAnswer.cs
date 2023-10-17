using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Answer_", menuName = "Dialog/Dialog Answer")]
public class DialogAnswer : ScriptableObject
{
    [SerializeField] private string _text;
    [SerializeField] private Dialog _nextDialog;
    [SerializeField] private Signal _signal;

    public string text => _text;
    public Dialog nextDialog => _nextDialog;
    public Signal signal => _signal;
}
