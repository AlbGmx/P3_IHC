using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    public Material activeMaterial = null;
    public Material inactiveMaterial = null;
    private MeshRenderer meshRenderer = null;

    private void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = inactiveMaterial;  
    }

    public override void Interact(){
        base.Interact();
        meshRenderer.material = activeMaterial;
    }
}