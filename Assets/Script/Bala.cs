using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private float vel;
    public Vector3 dist;
    private float pos_ini;
    // Start is called before the first frame update
    void Start()
    {
        vel = 0.3f;
        pos_ini = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        dist = dist.normalized;
        this.transform.Translate(0, 0, vel * Time.deltaTime);
        if (this.transform.position.x > pos_ini + 130)
        {
            destruir();
        }
   
    }
    
    private void destruir()
    {
        Destroy (gameObject);
    }
}
