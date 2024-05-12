using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azaltarttır : MonoBehaviour
{
    public DersData data;

    public void DecreaseDogruSay()
    {
        data.dogru -= 1;
        data.updated.Invoke();
    }
    public void DecreaseyYanlisSay()
    {
        data.yanlis -= 1;
        data.updated.Invoke();
    }
    public void DecreaseBosSay()
    {
        data.bos -= 1;
        data.updated.Invoke();
    }

    public void IncreaseDogruSay()
    {
        data.dogru += 1;
        data.updated.Invoke();
    }
    public void IncreaseYanlisSay()
    {
        data.yanlis += 1;
        data.updated.Invoke();
    }
    public void IncreaseBosSay()
    {
        data.bos += 1;
        data.updated.Invoke();
    }
}
