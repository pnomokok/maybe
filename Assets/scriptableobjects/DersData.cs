using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(menuName = "scriptable object/ ders data")]
public class DersData : ScriptableObject
{
    [HideInInspector] public UnityEvent updated;
    public int dogru;
    public int yanlis;
    public int bos;

    private void OnEnable()
    {
        if (updated == null)
            updated = new UnityEvent();
    }

    private void OnValidate()
    {

        updated.Invoke();
    }
}
