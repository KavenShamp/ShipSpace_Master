using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public GameObject personaje;
    public Animator anim;
    void Start()
    {
          anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void   OnCollisionEnter(Collision colision){

        anim.SetBool("abrir",true);
    }
    private void   OnCollisionExit(Collision colision){

        anim.SetBool("abrir",false);
    }
    
}
