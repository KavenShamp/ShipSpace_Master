using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.U;

public class diamante : MonoBehaviour
{
    public GameObject wea;
    public AudioSource Sonido;
  // public Text NumeroLave;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){

      //  if(collision.gameObject.tag =="Player"){
       //   NumeroLave.Text = "1"; 
       // Sonido.Play();
       // Destroy.Play();
        Destroy(this.gameObject);
       // }

    }
}
