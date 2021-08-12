using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class baslasc : MonoBehaviour
{
    public GameObject baslapanel;
    int toplampuan;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip nurunsesi;

    void Start()
    {

        StartCoroutine(nurcal());
        baslapanel.GetComponent<CanvasGroup>().DOFade(0, 2f);

        PlayerPrefs.DeleteAll(); // Kayıtlı tüm anahtar ve verileri siler
        toplampuan = 0;
        PlayerPrefs.SetInt("totalScoreKey", toplampuan);
        PlayerPrefs.SetInt("hareketgercekles", 0);
        Invoke("sil", 2f);
       
    }

    void sil()
    {
        Destroy(baslapanel);
    }
    IEnumerator nurcal()
    {
        yield return new WaitForSecondsRealtime(2f);
        audioSource.PlayOneShot(nurunsesi);

    }

}
