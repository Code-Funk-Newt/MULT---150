using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp_Animation : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("A", Input.GetAxis("Horizontal"));
        anim.SetFloat("D", Input.GetAxis("Horizontal"));

        anim.SetFloat("S",Input.GetAxis("Vertical"));
        anim.SetFloat("W",Input.GetAxis("Vertical"));
    }
}
