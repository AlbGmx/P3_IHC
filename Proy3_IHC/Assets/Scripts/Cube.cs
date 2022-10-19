using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    public Material activeMaterial;
    public Material inactiveMaterial;
    private MeshRenderer meshRenderer = null;
    public bool isActive = false;

    private void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = activeMaterial;
        isActive = true;
    }

    public override void Interact(){
        base.Interact();
        if ( isActive  ){
            Debug.Log("Cubo desactivado");
            meshRenderer.material = inactiveMaterial;
            isActive = false;
        } else {
            Debug.Log("Cubo activado");
            meshRenderer.material = activeMaterial;
            isActive = true;
        }
    }
}