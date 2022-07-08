/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimPlayer : MonoBehaviour
{
    private Vector3 seguir = new Vector3(0,6,-1);
    private float ang_rotate;
    private float ang;
    private Vector3 Dist;
    private int angle_redir;
    private GameObject player;
    private Vector3 characterPos;
 
    // public Camera cams;
    void Start()
    {
        angle_redir = 180;
        Cursor.lockState = CursorLockMode.Confined;
        player = GameObject.FindWithTag("PositionControler");
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
        //Debug.Log(posPLane.GetPoint(20).x);

        characterPos = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
        this.transform.position = player.transform.position;
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimPlayer : MonoBehaviour
{
    private float ang_rotate;
    private float ang;
    private Vector3 Dist;
    private GameObject player;

    public Animator anim;
  

    public int balas = 30;
    public GameObject bala;
    private Vector3 pos;

    private Vector3 espacio;

    // public Camera cams;
    void Start()
    {
        player = GameObject.FindWithTag("PositionControler");
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Ray posPLane = Camera.main.ScreenPointToRay(Input.mousePosition);

        Dist = new Vector3(posPLane.GetPoint(20).x - this.transform.position.x, this.transform.position.y, posPLane.GetPoint(20).z - this.transform.position.z);
        //Debug.Log(Dist);
        ang = Mathf.Atan2(Dist.x, Dist.z);
        ang_rotate = ang * (180 / Mathf.PI);// * -1;// + angle_redir;
        Quaternion angle = Quaternion.Euler(0, ang_rotate, 0);
        this.transform.rotation = angle;
        //Debug.Log(posPLane.GetPoint(20).x);


        this.transform.position = player.transform.position;

        espacio = new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z - 1);
        Disparar();

    }

    void Disparar()
    {
        if (Input.GetKeyDown("mouse 0") && balas >= 0)
        {
            balas = balas - 1;
            print("estoy disparando ");
            Instantiate(bala, espacio, transform.rotation);

        }
        if (balas == 0)
        {
            balas = balas + 30;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            print("recargando");
            balas = 30;
        }
    }

    /*
        public int balas = 30;
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
            if (Input.GetKeyDown("mouse 0") && balas > 0)
            {
                balas -= 1;

                Instantiate(bala, new Vector3((Rifle.transform.position.x + Rifle.GetComponent<BoxCollider>().size.x), Rifle.transform.position.y, (Rifle.transform.position.z + Rifle.GetComponent<BoxCollider>().size.z)), this.transform.rotation);

            }
    */


}