using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acmakapamasahne1 : MonoBehaviour
{
    [SerializeField]
    private GameObject ekran;

    [SerializeField]
    private GameObject ekraniki;

    private bool ekranIsEnabled;



    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip ackapalick;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ackapa);
        ekranIsEnabled = false;
        ekran.SetActive(ekranIsEnabled);
        ekraniki.SetActive(ekranIsEnabled);

    }


    public void ackapa()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(ackapalick);
        }
        
        ekranIsEnabled ^= true;
        ekran.SetActive(ekranIsEnabled);
        ekraniki.SetActive(ekranIsEnabled);

    }
}
