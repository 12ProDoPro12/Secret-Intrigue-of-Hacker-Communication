using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Signal : ScriptableObject
{
    private List<SignalListener> listeners;

    public void Call()
    {
        foreach(SignalListener listener in listeners)
        {
            listener.RecieveSignal();
        }
    }

    public void AddListener(SignalListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(SignalListener listener)
    {
        listeners.Remove(listener);
    }
}
