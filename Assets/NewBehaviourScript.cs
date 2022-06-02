using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cubo;
    public GameObject camara;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            cubo.transform.position = cubo.transform.position + new Vector3(0, 0.1f, 0);
            camara.transform.position = camara.transform.position + new Vector3(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            cubo.transform.position = cubo.transform.position - new Vector3(0, 0.1f, 0);
            camara.transform.position = camara.transform.position - new Vector3(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cubo.transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cubo.transform.Translate(-0.1f, 0, 0);
        }
    }
}
