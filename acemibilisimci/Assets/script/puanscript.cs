using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puanscript : MonoBehaviour
{
    int toplampuan=0;
    public GameObject durumbar;
    public float durum;
   public Text puanText;
    private void Start()
    {
        
        Score();
        puanText.text =  "Çalışır Durum % " + toplampuan.ToString();
        durum = toplampuan;
        
    }


    private void Update()
    {
        durumbar.transform.localScale = new Vector3(durum/100, 1, 1);
        if(durum <= 0)
        {
            durum = 0;
        }
        if (durum >= 100)
        {
            durum = 100;
            puanText.text = "% " + toplampuan.ToString();
        }
    }



    public void Score()
    {
        
        if (PlayerPrefs.HasKey("totalScoreKey"))  //totalScoreKey anahtarıyla kaydedilmiş bir veri var mı ?
        {
            toplampuan = PlayerPrefs.GetInt("totalScoreKey"); // totalScoreKey anahtarıyla kaydedilmiş veriyi getir
            Debug.Log("PlayerPrefs totalScoreKey var");
        }
        else
        {
            Debug.Log("totalScoreKey kayıtlarda yok");
        }

        
        PlayerPrefs.SetInt("totalScoreKey", toplampuan);
    }


    public void ResetScore()
    {
        PlayerPrefs.DeleteAll(); // Kayıtlı tüm anahtar ve verileri siler
        toplampuan = 0;
        Debug.Log("The score was reset!");
    }

}
