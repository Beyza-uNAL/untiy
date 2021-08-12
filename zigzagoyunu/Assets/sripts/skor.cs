using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skor : MonoBehaviour
{
    public static int Skor;
    public Text skortext;
    // Start is called before the first frame update
    void Start()
    {
        Skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skortext.text = Skor.ToString();
    }
}
