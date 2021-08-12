using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farescript : MonoBehaviour
{
    bool soltikabasildimi;
    bool sagtikbasildimi;
    [SerializeField]
    private GameObject soltik;
    [SerializeField]
    private GameObject sagtik;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip fareclick;




    void Start()
    {
        soltikabasildimi= false;
        sagtikbasildimi = false;

        soltik.SetActive(false);
        sagtik.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            soltikabasildimi = true;
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(fareclick);
            soltik.SetActive(true);
            Invoke("soltikbas", .5f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            sagtikbasildimi = true;
            if (PlayerPrefs.GetInt("sesDurumu") == 1)
                audioSource.PlayOneShot(fareclick);
            sagtik.SetActive(true);
            Invoke("sagtikbas", .5f);
        }

    }

    public void soltikbas()
    {
        if(soltikabasildimi==true)
        {
     
            soltikabasildimi = false;
            soltik.SetActive(false);
        }
        
    }
    public void sagtikbas()
    {
        if (sagtikbasildimi == true)
        {
            sagtikbasildimi = false;
            sagtik.SetActive(false);
        }
        
    }
}
