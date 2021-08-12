using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketkodu : MonoBehaviour
{
    [SerializeField]
    private GameObject sonkapak;

    [SerializeField]
    private GameObject sonmoni;

    Rigidbody2D rigid;
    public int hiz=100;
    int toplampuan;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip collissionclick;

    pause bitis;
    bool hareketgerceklesti;

    void Start()
    {
        hareketgerceklesti = false;
        bitis = Object.FindObjectOfType< pause>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid = GetComponent<Rigidbody2D>();
        float yatay = Input.GetAxis("Horizontal");
        Hareket(yatay);

    }
    void Hareket(float yatay)
    {
        rigid.velocity = new Vector2(hiz * yatay, rigid.velocity.y);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(collissionclick);

        }

        hareketgerceklesti = true;
        if (hareketgerceklesti == true)
        {
            PlayerPrefs.SetInt("hareketgercekles", 1);
            Invoke("hareketgercek", .5f);
        }
        bitis.bitispanelac();
        

        hiz = 0;

    }


    private void Update()
    {
        if (hiz == 0)
        {
            sonkapak.SetActive(true);
            sonmoni.SetActive(true);
        }
    }

   public void hareketgercek()
    {
        toplampuan = 100;
        PlayerPrefs.SetInt("totalScoreKey", toplampuan);
    }

}
