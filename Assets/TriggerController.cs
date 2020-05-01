using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Light light = GameObject.Find("Directional Light").GetComponent<Light>();

        if (other.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.red;
            light.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Light light = GameObject.Find("Directional Light").GetComponent<Light>();

        if (other.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.red;
            light.color = Color.white;
        }
    }
}
