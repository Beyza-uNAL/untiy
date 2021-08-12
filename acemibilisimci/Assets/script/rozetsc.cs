using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class rozetsc : MonoBehaviour
{
   

    bool rozetacikmi;
    [SerializeField]
    private GameObject srozetimg;

 
    void Start()
    {
        srozetimg.SetActive(false);
        rozetacikmi = false;
        srozetimg.GetComponent<RectTransform>().localPosition = new Vector3(-741, 325, 0);
        if (PlayerPrefs.GetInt("hareketgercekles") == 1)
        {
            rozett();
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void rozett()
    {
     
            if (!rozetacikmi)
            {
                srozetimg.SetActive(true);
                srozetimg.GetComponent<RectTransform>().DOLocalMoveX(-615, 0.5f);
                rozetacikmi = true;
            }
            else
            {

                srozetimg.GetComponent<RectTransform>().DOLocalMoveX(-741, 0.5f);
                rozetacikmi = false;
                srozetimg.SetActive(false);
        }
        
    }
}
