using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion_level : MonoBehaviour
{
    private GameObject ship;
    private GameObject _camera;
    private float Dist;
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
        _camera = Camera.main.gameObject;
    }
    //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":3194.800048828125,"y":-0.8241004943847656,"z":110.0},
    void Update()
    {
        Dist = (this.transform.position.x - ship.transform.position.x);

        if (Dist < 118)
        {
            //_camera.GetComponent<Camera>().orthographic = false;
            //Debug.Log(_camera.GetComponent<Camera>().orthographic);
            ship.GetComponent<Player_ship>().enabled = false;
            ship.GetComponent<Rigidbody>().isKinematic = true;
            //trigger animacion camara y player
        }
    }
}
