using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFOV : MonoBehaviour
{
    private float ang_rotate;
    private float ang;
    private Vector3 Dist;
    private Vector3 pos_bala;
    private GameObject character;
    public GameObject enemy;
    public GameObject bala;
    private int angle_redir;
    private GameObject Timer;
    void Start()
    {

        angle_redir = 180;
        character = GameObject.FindWithTag("Player");
        Timer = GameObject.Find("Reloj");

    }

    void Update()
    {
        Dist = new Vector3(character.transform.position.x - this.transform.position.x, character.transform.position.y - this.transform.position.y, character.transform.position.z - this.transform.position.z);

        RaycastHit hit;
        Debug.DrawRay(this.transform.position, Dist, Color.white);

        if (Physics.Raycast(this.transform.position, Dist, out hit, 30f))
        {

            if (hit.transform.tag == "Player")
            {
                character = GameObject.Find("player");
                ang = Mathf.Atan2(Dist.z, Dist.x);
                ang_rotate = ang * (180 / Mathf.PI) * -1 + angle_redir;
                Quaternion angle = Quaternion.Euler(0, ang_rotate + 90, 0);
                this.transform.rotation = angle;
            }
        }

  /*      if ((Timer.GetComponent<Contador>()._Time) % 2 == 0)
        {
            Disparo();
        }
*/



    }

    void Disparo()
    {

        Vector3 pos_bala = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

       // bala.GetComponent<movLaser>().distancia = new Vector3(Dist.x, Dist.y + (this.transform.position.y + 5), Dist.z);

       // Instantiate(bala, pos_bala, Quaternion.Euler(0, 0, 0));
    }
}
