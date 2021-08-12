using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class seskontrol : MonoBehaviour
{
    bool sespaneliacikmi;
    bool yardimpaneliacikmi;
    bool nasilpaneliacikmi;
    [SerializeField]
    private GameObject sespaneli;
    [SerializeField]
    private GameObject nasilpaneli;

    [SerializeField]
    private GameObject yardimimg;
    [SerializeField]
    private GameObject yardimbtn;
    [SerializeField]
    private GameObject yardimpaneli;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip buttonclick;

    private void Start()
    {
        yardimpaneli.SetActive(false);
        nasilpaneliacikmi = false;
        PlayerPrefs.SetInt("sesDurumu", 1);
        sespaneliacikmi = false;
        yardimpaneliacikmi = false;
        sespaneli.GetComponent<RectTransform>().localPosition=new Vector3(-93, 25, 0);
        yardimimg.GetComponent<RectTransform>().localPosition = new Vector3(0, 525, 0);
        yardimbtn.GetComponent<RectTransform>().localPosition = new Vector3(1, 370, 0);
    }

    public void sesiac()
   {
        PlayerPrefs.SetInt("sesDurumu", 1);
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
            audioSource.PlayOneShot(buttonclick);
        

   }

public void sesikapat()
    {

        PlayerPrefs.SetInt("sesDurumu", 0);
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
            audioSource.PlayOneShot(buttonclick);
    }

public void ayarlariyap()
    {
        if(!sespaneliacikmi)
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);
            sespaneli.GetComponent<RectTransform>().DOLocalMoveX(78,0.5f);
            sespaneliacikmi = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);
            sespaneli.GetComponent<RectTransform>().DOLocalMoveX(-93, 0.5f);
            sespaneliacikmi = false;
        }
    }




    public void yardimayarlariyap()
    {
        if (!yardimpaneliacikmi)
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);
            yardimimg.GetComponent<RectTransform>().DOLocalMoveY(400, 0.5f);
            yardimbtn.GetComponent<RectTransform>().DOLocalMoveY(247, 0.5f);
            yardimpaneliacikmi = true;
            Invoke("panelgizli", 0.5f);
        }
        else
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);
            yardimimg.GetComponent<RectTransform>().DOLocalMoveY(525, 0.5f);
            yardimbtn.GetComponent<RectTransform>().DOLocalMoveY(370, 0.5f);
            nasilpaneliacikmi = false;
            nasilpaneli.GetComponent<CanvasGroup>().DOFade(0, .5f);
            yardimpaneliacikmi = false;
            yardimpaneli.SetActive(false);
        }
    }

    void panelgizli()
    {
        yardimpaneli.SetActive(true);
    }


   public void nasiloynanir()
    {
        if (!nasilpaneliacikmi)
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);
            nasilpaneli.GetComponent<CanvasGroup>().DOFade(1, 1.5f);
            nasilpaneliacikmi = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(buttonclick);

            nasilpaneliacikmi = false;
            nasilpaneli.GetComponent<CanvasGroup>().DOFade(0, .5f);
        }
    }

}

