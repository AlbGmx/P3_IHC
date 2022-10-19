using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    private bool isInsideZone;
 
    public InputAction interactAction;

    private void OnEnable() {
        interactAction.Enable();
    }

    public virtual void Interact(){
        Debug.Log("Interactuando con " + gameObject.name);  
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("Presiona I para interactuar con " + gameObject.name);
            isInsideZone = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("Has salido del rango de interacción de " + gameObject.name);
            isInsideZone = false;
        }
    }

    // Update is called once per frame
    void Update(){
        if(isInsideZone){
            //if(Input.GetKeyDown(KeyCode.I)){
            if(interactAction.WasPerformedThisFrame()){
                Interact();
            }
        }
    }
}
