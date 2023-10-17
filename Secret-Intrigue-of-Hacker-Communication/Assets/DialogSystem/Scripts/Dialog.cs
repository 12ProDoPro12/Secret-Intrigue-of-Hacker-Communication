using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog_", menuName = "Dialog/Dialog")]
public class Dialog : ScriptableObject
{
    [SerializeField] private List<string> _textParts;
    [SerializeField] private List<DialogAnswer> _dialogAnswer;

    public List<string> textParts => _textParts;
    public List<DialogAnswer> dialogAnswer => _dialogAnswer;
    ///public List<DialogVariant> variants;
}
