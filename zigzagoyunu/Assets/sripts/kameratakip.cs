using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{

    public Transform topunkonumu;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - topunkonumu.position;
    }


    void Update()
    {
        if (tophareketi.dustu_mu == false)
        {
            transform.position = topunkonumu.position + fark;
        }
    }
}
