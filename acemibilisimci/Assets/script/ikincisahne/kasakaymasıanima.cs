using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class kasakaymasıanima : MonoBehaviour
{
   public Animator kasaanim;
   public Animator kasaorta;
   public Animator monit;
   public Animator fircaa;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip tusclick;
    [SerializeField]
    private AudioClip fanslotbilgi;

    [SerializeField]
    private AudioClip fansokmesesi;
    [SerializeField]
    private AudioClip stusuclick;
    [SerializeField]
    private AudioClip islemonaysesi;
 
    [SerializeField]
    private AudioClip geitaksf;
    [SerializeField]
    private AudioClip sonklavyeokyon;

    [SerializeField]
    private GameObject kasaon;

    [SerializeField]
    private GameObject kasayan;

    [SerializeField]
    private GameObject islemci;
    [SerializeField]
    private GameObject slot;

    [SerializeField]
    private GameObject fan;
    [SerializeField]
    private GameObject sonkasa;
    [SerializeField]
    private GameObject fircaimg;
  
    bool olaysonmu = false;
    bool geritaktimi = false;
    bool gectimi = false;
    bool sonlandimi = false;
    int a=0 ,b=0 , c=0 , d=0;

    hareketkodu harekets;
    
    [SerializeField]
    private Text puanText;

    bool sfok = false;
    int puan=0;
    int toplampuan=0;

    private void Start()
    {
        
        fircaimg.SetActive(false);
        harekets = Object.FindObjectOfType<hareketkodu>();
       
        fircaimg.GetComponent<RectTransform>().localPosition = new Vector3(156, 0, 0);
    }

    private void FixedUpdate()
    {
        if (sonlandimi == true)
        {
            puan = 30;
            toplampuan = puan;
            PlayerPrefs.SetInt("totalScoreKey", toplampuan);
        }
        if (geritaktimi == true)
        {
            puan = 60;
            toplampuan = puan;
            PlayerPrefs.SetInt("totalScoreKey", toplampuan);
        }
        if (olaysonmu == true)
        {
            puan = 90;
            toplampuan = puan;
            PlayerPrefs.SetInt("totalScoreKey", toplampuan);
        }
        if (PlayerPrefs.GetInt("hareketgercekles") == 1)
        {
            harekets.hareketgercek();

            puan = 100;
            toplampuan = puan;
            puanText.text = toplampuan.ToString();



        }

    }
    void Update()
    {
        


        



        if (Input.GetKeyDown(KeyCode.Space))
         {
            //Debug.Log(" Space TUŞUNA BASILDI");
           

            if (PlayerPrefs.GetInt("sesDurumu") == 1)
            {
                audioSource.PlayOneShot(tusclick);

            }

            kasaanim.SetBool("calistimi",false);
            monit.SetBool("monitor", false);
            


        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioSource.PlayOneShot(fanslotbilgi);
            StartCoroutine(sescalbekle());
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
            {
                audioSource.PlayOneShot(tusclick);

            }
            kasaorta.SetBool("kasaortala", false);


           
            Invoke("Fonksiyon", 2.5f);
            

        }

        if (sonlandimi==true)
        {
           
            kasaon.SetActive(false);
            kasayan.SetActive(true);
            fan.SetActive(true);
            slot.SetActive(true);     
            islemci.SetActive(true);
            Invoke("islemcifunction", .5f);

        }


        if (gectimi == true)
        {
            sonlandimi = false;
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                if (PlayerPrefs.GetInt("sesDurumu") == 1)
                {
                    audioSource.PlayOneShot(tusclick);

                }
               
                PlayerPrefs.SetInt("totalScoreKey", puan);
                fan.SetActive(false);
                a=1;
                if (gectimi == true)
                {
                    Invoke("ftusu", .5f);
                }
                
                

            }

            if (a == 1)
            {
               
                
                if (Input.GetKeyDown(KeyCode.S))
                {

                    if (PlayerPrefs.GetInt("sesDurumu") == 1)
                    {
                        audioSource.PlayOneShot(tusclick);

                    }
                    
                   
                    slot.SetActive(false);
                    b = 1;
                    if (gectimi == true)
                    {
                        Invoke("stusu", .5f);
                    }

                }
            }






        }




        if (Input.GetKeyDown(KeyCode.T))
           
            {

           
            if (b == 1 && a == 1)
            {
                
                if (PlayerPrefs.GetInt("sesDurumu") == 1)
                {
                    audioSource.PlayOneShot(tusclick);

                }

                fircaimg.SetActive(true);
                fircaa.SetBool("fircala", false);
                fircaimg.GetComponent<RectTransform>().DOLocalMoveX(780, .5f).SetDelay(3f);


            

                    geritaktimi = true;

            }
        }


        if (geritaktimi == true)
        {
            gectimi = false;
            if (sfok == false)
            {
                StartCoroutine(geritakbilgi());
                audioSource.PlayOneShot(geitaksf);
                StartCoroutine(ttuu());
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                sfok = true;
                if (PlayerPrefs.GetInt("sesDurumu") == 1)
                {
                    audioSource.PlayOneShot(tusclick);

                }
                
                
                slot.SetActive(true);
                d=1;

                


            }
            if (d == 1)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (PlayerPrefs.GetInt("sesDurumu") == 1)
                    {
                        audioSource.PlayOneShot(tusclick);

                    }
                   
                   
                    fan.SetActive(true);
                    c = 1;

                }
            }

            if (d == 1 && c==1)
            {
               
                olaysonmu = true;
               
                
            }



            

            if (olaysonmu == true)
            {

                StartCoroutine(ucsnbekle());
                Invoke("sonfonksiyon", 3f);
                
            }



           
               
                
            
        }









    }

    void Fonksiyon()
    {
       
        sonlandimi = true;
        
     
    }

    void islemcifunction()
    {
       
        gectimi = true;
       
       
    }



    void sonfonksiyon()
    {
        sfok = false;
        olaysonmu = false;
        Destroy(kasaon);
        kasayan.SetActive(false);
        fan.SetActive(false);
        slot.SetActive(false);
        islemci.SetActive(false);
        sonkasa.SetActive(true);
        
    }


    IEnumerator sescalbekle()
    {
        
        yield return new WaitForSecondsRealtime(7.5f);
        audioSource.PlayOneShot(fansokmesesi);
        


    }
    IEnumerator ucsnbekle()
    {
        yield return new WaitForSecondsRealtime(1.4f);
        if (sfok == true)
        {
            audioSource.PlayOneShot(sonklavyeokyon);
        }
        yield return new WaitForSecondsRealtime(8.4f);
        audioSource.Stop();

    }
    IEnumerator geritakbilgi()
    {
        
        yield return new WaitForSecondsRealtime(7.5f);
       


    }


    void ftusu()
    {
        audioSource.PlayOneShot(stusuclick);
    }

    void stusu()
    {
        audioSource.PlayOneShot(islemonaysesi);
    }
    IEnumerator ttuu()
    {
        yield return new WaitForSecondsRealtime(1.4f);
        sfok = true;

    }


}
