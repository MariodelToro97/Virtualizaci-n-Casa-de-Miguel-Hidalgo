using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamparas : MonoBehaviour {

    public GameObject luz;

    public bool encendida = false;


    void OnTriggerStay(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            luz.SetActive(true);
            encendida = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            luz.SetActive(false);
            encendida = false;
        }
    }
}
