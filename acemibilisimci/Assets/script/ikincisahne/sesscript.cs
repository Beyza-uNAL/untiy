using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesscript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip bipsesi;

    [SerializeField]
    private AudioClip kisasesi;
    [SerializeField]
    private AudioClip bizesesi;
    [SerializeField]
    private AudioClip simdiadimsesi;
    [SerializeField]
    private AudioClip spacesesi;


    void Start()
    {

        audioSource.mute = false;
        audioSource.PlayOneShot(bipsesi);
            StartCoroutine(bipcal());
        

    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
            audioSource.mute = true;
        

    }

    IEnumerator bipcal()
    {
        
            yield return new WaitForSecondsRealtime(1f);
            audioSource.PlayOneShot(bipsesi);
            yield return new WaitForSecondsRealtime(1f);
            audioSource.PlayOneShot(bipsesi);
            yield return new WaitForSecondsRealtime(1f);
            audioSource.PlayOneShot(bipsesi);
            yield return new WaitForSecondsRealtime(1f);
            audioSource.PlayOneShot(bipsesi);

            yield return new WaitForSecondsRealtime(1.5f);
            audioSource.PlayOneShot(kisasesi);
            yield return new WaitForSecondsRealtime(2.2f);
            audioSource.PlayOneShot(bizesesi);
            yield return new WaitForSecondsRealtime(3.2f);
            audioSource.PlayOneShot(simdiadimsesi);
            yield return new WaitForSecondsRealtime(3.2f);
            audioSource.PlayOneShot(spacesesi);
        
    }


}
