using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : Interactable
{
    private Rigidbody rb;
    public float speed = 10f;
    void Start(){
        rb = GetComponent<Rigidbody>();        
    }

    //rotate cilinder on Y axis when interacted
    public override void Interact(){
        base.Interact();
        rb.AddTorque(Vector3.left*speed, ForceMode.Impulse);
    }


}