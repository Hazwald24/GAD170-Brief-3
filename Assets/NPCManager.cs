using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public enum NPCState { Day, Night};

    NPCState myNPCState;

    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (myNPCState)
        {
            case NPCState.Day:
                Debug.Log("Set Day has been called");
                r.material.color = Color.yellow;
                break;

            case NPCState.Night:
                Debug.Log("Set Night has been called");
                r.material.color = Color.black;
                break;

            default:

                break;
        }
    }

    public void SetNight()
    {
        myNPCState = NPCState.Night;
    }

    public void SetDay()
    {
        myNPCState = NPCState.Day;
    }
}
