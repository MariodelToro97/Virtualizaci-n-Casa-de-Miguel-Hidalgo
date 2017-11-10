	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciónEscalera : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    void Start () {

        //rend = GetComponent<Renderer>();
        //rend.enabled = true;
        //rend.sharedMaterial = material[0];

        GameObject Escalon1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject Escalon2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject Escalon3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject Escalon4 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        Escalon1.transform.localScale = new Vector3(0.3f, 0.25f, 1.7f);
        Escalon1.transform.position = new Vector3(5.15f, 0.125f, 9.72f);

        Escalon2.transform.localScale = new Vector3(0.3f, 0.5f, 1.7f);
        Escalon2.transform.position = new Vector3(5.45f, 0.25f, 9.72f);

        Escalon3.transform.localScale = new Vector3(0.3f, 0.75f, 1.7f);
        Escalon3.transform.position = new Vector3(5.75f, 0.375f, 9.72f);

        Escalon4.transform.localScale = new Vector3(0.3f, 1f, 1.7f);
        Escalon4.transform.position = new Vector3(6.05f, 0.5f, 9.72f);        
    }
}
