using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skor : MonoBehaviour
{
    [SerializeField]
    private Text puanText;
    int toplampuan;
    void Start()
    {
        if (PlayerPrefs.HasKey("totalScoreKey")) 
        {
            toplampuan = PlayerPrefs.GetInt("totalScoreKey"); 
        }
        puanText.text = toplampuan.ToString();

    }



}
