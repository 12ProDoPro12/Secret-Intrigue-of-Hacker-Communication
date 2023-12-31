using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public Signal signal;
    public UnityEvent OnRecieveSignal;
    public void RecieveSignal()
    {
        OnRecieveSignal.Invoke();
    }

    private void OnEnable()
    {
        signal.AddListener(this);
    }

    private void OnDisable()
    {
        signal.RemoveListener(this);
    }
}
