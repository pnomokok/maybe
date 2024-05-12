using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deneme : MonoBehaviour
{
    public void baslangic()
    {
        SceneManager.LoadScene("baslangic");
    }
    public void sayfa_gecis()
    {
        SceneManager.LoadScene("sayfa_gecis");
    }
    public void sonuc_ekle_ilerleme()
    {
        SceneManager.LoadScene("sonuc_ekle_ilerleme");
    }
    public void sonuc_gor_ilerleme()
    {
        SceneManager.LoadScene("sonuc_gor_ilerleme");
    }

}
