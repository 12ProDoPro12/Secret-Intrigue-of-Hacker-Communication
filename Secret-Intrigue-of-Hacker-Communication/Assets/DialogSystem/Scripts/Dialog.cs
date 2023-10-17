using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog_", menuName = "Dialog/Dialog")]
public class Dialog : ScriptableObject
{
    [SerializeField] private List<string> _textParts;
    [SerializeField] private List<DialogAnswer> _dialogAnswer;
    [SerializeField] private Signal _signal;

    public List<string> textParts => _textParts;
    public List<DialogAnswer> dialogAnswer => _dialogAnswer;
    public Signal signal => _signal;
    ///public List<DialogVariant> variants;
}
