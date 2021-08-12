using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncuscript : MonoBehaviour
{

    public Transform yol1;
    public Transform yol2;
    bool sag;
    bool sol;
    // Start is called before the first frame update
    void Start()
    {
        sag = false;
        sol = false;
    }

    // Update is called once per frame
    void Update()
    {
        hareket();
    }

    void hareket()
    {
  

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            sag = true;
            sol = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sol = true;
            sag = false;
        }

        if (sag)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(1.5f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
        if (sol)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-1.5f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
        transform.Translate(0, 0, 5 * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "son1")
        {
            yol2.position = new Vector3(yol1.position.x, yol1.position.y, yol1.position.z + 10.0f);
            Debug.Log("yol1");
        }
        if (other.gameObject.name == "son2")
        {
            Debug.Log("yol2");
            yol1.position = new Vector3(yol2.position.x, yol2.position.y, yol2.position.z + 10.0f);
        }
    }
}
