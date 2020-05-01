using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;

    //public Animator animator;

    //public Transform spriteChildTransform;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //getting the input from the vertical axis. times by speed. Storing in 'translation' float.
        float translationVertical = Input.GetAxis("Vertical") * speed;
        //same but for horizontal
        float translationHorizontal = Input.GetAxis("Horizontal") * speed;

        //animator.SetFloat("Vertical", translationVertical);


        //translating the transform on this object, times verctor forward, times deltatime, times the translation which is the input
        transform.Translate(Vector3.forward * Time.deltaTime * translationVertical);
        //same but for horizontal
        transform.Translate(Vector3.right * Time.deltaTime * translationHorizontal);


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4f;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 1f;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            speed = 2f;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * translationVertical * speed);
        transform.Translate(Vector3.right * Time.deltaTime * translationHorizontal * speed);

        /*

        if(translationHorizontal > 0)
        {
            spriteChildTransform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            spriteChildTransform.localScale = new Vector3(1f, 1f, 1f);
        }
        */
    }
}
