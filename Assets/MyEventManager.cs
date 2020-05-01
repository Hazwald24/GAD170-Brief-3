using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyEventManager : MonoBehaviour
{

    public UnityEvent Daytime = new UnityEvent();
    public UnityEvent Nighttime = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Nighttime != null)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                Nighttime.Invoke();
            }
        }
        else
        {
            Debug.Log("Nighttime event is null");
        }

        if (Daytime != null)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Daytime.Invoke();
            }
        }

        else
        {
            Debug.Log("Daytime event is null");
        }
    }
}
