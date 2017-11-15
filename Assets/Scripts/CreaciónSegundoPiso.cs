using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciónSegundoPiso : MonoBehaviour {

    public Material material;
    Renderer rend;

    void Start () {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material;

        GameObject Piso = GameObject.CreatePrimitive (PrimitiveType.Cube);
		GameObject Piso2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		GameObject Piso3 = GameObject.CreatePrimitive (PrimitiveType.Cube);

		Piso.transform.localScale = new Vector3 (5.5f, 1.0f, 8.36f);
		Piso.transform.position = new Vector3 (3.45f, 0.5f, 15.39f);

		Piso2.transform.localScale = new Vector3 (5.5f, 1.0f, 6.27f);
		Piso2.transform.position = new Vector3 (3.45f, 0.5f, 3.835f);

		Piso3.transform.localScale = new Vector3 (35.63f, 1.0f, 20.30f);
		Piso3.transform.position = new Vector3 (24.03f , 0.5f, 10.165f);
        
    }
}
