/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_player : MonoBehaviour
{
    private float ang_rotate;
    private float ang;
    private Vector3 Dist;
    

    public Animator anim;
 
    // public Camera cams;
    void Start()
    {
       
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
    
        Ray posPLane = Camera.main.ScreenPointToRay(Input.mousePosition);

        Dist = new Vector3(posPLane.GetPoint(20).x - this.transform.position.x,this.transform.position.y, posPLane.GetPoint(20).z - this.transform.position.z);
        //Debug.Log(Dist);
        ang = Mathf.Atan2(Dist.x, Dist.z);
        ang_rotate = ang * (180 / Mathf.PI);// * -1;// + angle_redir;
        Quaternion angle = Quaternion.Euler(0, ang_rotate, 0);
        this.transform.rotation = angle;
        // Debug.Log(Dist);
        
        


    }
}*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_player : MonoBehaviour
{
    private Vector3 seguir = new Vector3(0, 12, -2);
    private float ang_rotate;
    private float ang;
    private Vector3 Dist;
    public GameObject camara;

    // public Camera cams;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        camara = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        camara.transform.position = transform.position + seguir;

        Ray posPLane = Camera.main.ScreenPointToRay(Input.mousePosition);

        Dist = new Vector3(posPLane.GetPoint(20).x - this.transform.position.x, this.transform.position.y, posPLane.GetPoint(20).z - this.transform.position.z);
        //Debug.Log(Dist);
        ang = Mathf.Atan2(Dist.x, Dist.z);
        ang_rotate = ang * (180 / Mathf.PI);
        Quaternion angle = Quaternion.Euler(0, ang_rotate, 0);
        this.transform.rotation = angle;
      
        
    }
}
