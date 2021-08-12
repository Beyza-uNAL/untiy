using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketi : MonoBehaviour
{
    Vector3 yon;
    public float hiz;
    public zeminspawnla zeminspawnerscript;
    public static bool dustu_mu;
    public float eklenecekhiz;
    void Start()
    {
        eklenecekhiz = 0.05f;
        hiz = 2;
        dustu_mu = false;
        yon = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            dustu_mu = true;
        }
        if(dustu_mu==true)
        {
            Debug.Log("Düştüm");
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
            hiz += eklenecekhiz * Time.deltaTime;
        } 
    }

    private void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hiz;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "zemin")
        {
            skor.Skor++; 
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspawnerscript.zemin_olustur();
            StartCoroutine(zeminisil(collision.gameObject));
        }
    }


    IEnumerator zeminisil(GameObject silinecekzemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinecekzemin);
    }

   
}
