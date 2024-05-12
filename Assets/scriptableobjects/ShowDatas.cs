using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowDatas : MonoBehaviour
{
    public DersData data;
    [SerializeField] private TMP_Text dogrusayisi;
    [SerializeField] private TMP_Text yanlissayisi;
    [SerializeField] private TMP_Text bossayisi;

    //private void Start()
    //{
    //    dogrusayisi.text = data.dogru.ToString();
    //    yanlissayisi.text = data.yanlis.ToString();
    //    bossayisi.text = data.bos.ToString();
    //}
    private void OnEnable()
    {
        data.updated.AddListener(UpdateDataDisplay);
    }

    private void OnDisable()
    {
        data.updated.RemoveListener(UpdateDataDisplay);
    }
    private void Start()
    {
        UpdateDataDisplay();
    }

    public void UpdateDataDisplay()
    {
        dogrusayisi.text = data.dogru.ToString();
        yanlissayisi.text = data.yanlis.ToString();
        bossayisi.text = data.bos.ToString();
    }

}
