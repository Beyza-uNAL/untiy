using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    [SerializeField]
    private GameObject pausepanel;
    [SerializeField]
    private GameObject bitispanel;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip oynaclick;

    [SerializeField]
    private AudioClip menuclick;

    [SerializeField]
    private AudioClip cikisclick;

    [SerializeField]
    private AudioClip buttonclick;

    int toplampuan;

    public void pausepanelac()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(buttonclick);

        }
        
        pausepanel.SetActive(true);
    }
    public void bitispanelac()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(buttonclick);

        }
       
        
        bitispanel.SetActive(true);
    }




    public void Yenidenoyna()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(oynaclick);

        }
        
        pausepanel.SetActive(false);
    }
    public void menuyedon()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(menuclick);

        }
        
        SceneManager.LoadScene("menu");
    }
    public void oyundancik()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(cikisclick);

        }
        
        Application.Quit();
    }
}
