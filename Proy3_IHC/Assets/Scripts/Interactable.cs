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
        Debug.Log("Interact");
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("Jugador en rango");
            isInsideZone = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("Jugador fuera de rango");
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
