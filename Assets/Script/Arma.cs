using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int balas= 30;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Rifle = GameObject.FindGameObjectWithTag("Weapon");
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown("mouse 0") && balas>0)
        {
            balas-=1;

            Instantiate(bala, new Vector3((Rifle.transform.position.x + Rifle.GetComponent<BoxCollider>().size.x), Rifle.transform.position.y, (Rifle.transform.position.z + Rifle.GetComponent<BoxCollider>().size.z)) , this.transform.rotation);
            
        }

        
        if(Input.GetKeyDown(KeyCode.R) && balas == 0)
            {
           
            balas = 30;
        }
        
    }
}
