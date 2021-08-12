using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject takipedilen;
    Vector3 mesafe;

    private void Start()
    {
        mesafe = transform.position - takipedilen.transform.position;
    }
    void Update()
    {
        transform.position = takipedilen.transform.position + mesafe;
    }
}
