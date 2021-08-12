using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deneme : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip buttonclick;


    public void dene()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(buttonclick);

        }
        
        SceneManager.LoadScene("ikincisahne");
    }
    public void dene3()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(buttonclick);

        }
       
        SceneManager.LoadScene("ucuncusahne");
    }
    public void dene4()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            audioSource.PlayOneShot(buttonclick);

        }
        
        SceneManager.LoadScene("dorduncusahne");
    }

}
