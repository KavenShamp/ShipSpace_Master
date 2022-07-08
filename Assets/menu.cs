using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
     public GameObject UINuevoJuego;
    public GameObject UIGameplay;
    public void btnNuevoJuego(){

        UINuevoJuego.SetActive(false);
        UIGameplay.SetActive(true);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
