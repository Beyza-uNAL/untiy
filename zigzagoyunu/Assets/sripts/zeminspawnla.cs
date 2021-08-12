using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminspawnla : MonoBehaviour
{
    public GameObject sonzemin;
   
    void Start()
    {
        for(int i = 0; i<15; i++)
        {
            zemin_olustur();
           
        }
        
    }
   public void zemin_olustur()
    {
        Vector3 yon;
        if(Random.Range(0,2) == 0)
        {
            yon = Vector3.left;
        }
        else
        {
            yon = Vector3.forward;
        }

       sonzemin = Instantiate(sonzemin, sonzemin.transform.position + yon, sonzemin.transform.rotation);
    }
}
