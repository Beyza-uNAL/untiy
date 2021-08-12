using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sahnegecis : MonoBehaviour
{
    [SerializeField]
    private GameObject ekran2;
    [SerializeField]
    private GameObject ekran;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip baslaclick;
    [SerializeField]
    private AudioClip cikisclick;


    private void Start()
    {
        
        ekran2.SetActive(false);
    }
    public void ecikis()
    {
        if(PlayerPrefs.GetInt("sesDurumu")== 1)
        {
            audioSource.PlayOneShot(cikisclick);
        }
        
        Application.Quit();
    }


    public void basla()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(baslaclick);

        }
        
        ekran2.SetActive(true);
        ekran.SetActive(false);

    }
}
