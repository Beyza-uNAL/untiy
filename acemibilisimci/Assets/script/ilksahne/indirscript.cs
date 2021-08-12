using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class indirscript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip indirclick;

    [SerializeField]
    private GameObject arkakiz;
    [SerializeField]
    private GameObject kizkafa;

    //puanscript puansc;
    int toplampuan = 0;
    void Start()
    {
        
        PlayerPrefs.DeleteAll(); // Kayıtlı tüm anahtar ve verileri siler
        toplampuan = 0;
        PlayerPrefs.SetInt("totalScoreKey", toplampuan);

    }

    public void indirsahnegecis()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(indirclick);

        }
        Invoke("arkakafa", .5f);
       
    }


    public void arkakafa()
    {
        
        kizkafa.SetActive(false);
        arkakiz.SetActive(true);
        Invoke("kiz", 3f);
    }

    public void kiz()
    {
        SceneManager.LoadScene("menu");
    }


}
