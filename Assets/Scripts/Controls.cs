using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour

{
public PlayerInput inputs;
InputAction dir;
InputAction restart;
InputAction end;

// Les controls sont customisable dans l'input manager sinon bah c'est assez con il se tp de 20 en 20 utilisez pas le end il est hardcoder il pue la merde

    void Awake()
    {
        dir = inputs.actions.FindAction("dir"); 
        restart = inputs.actions.FindAction("Restart"); 
        end = inputs.actions.FindAction("End"); 
    }
    void Update()
    {
        // if(Input.mouseScrollDelta != Vector2.zero)
        // {
        //     this.transform.position += new Vector3(Input.mouseScrollDelta.y*20f,0,0);
        // }
        if(dir.triggered)
        {
            this.transform.position += new Vector3(dir.ReadValue<Vector2>().x*20f,dir.ReadValue<Vector2>().y*20f,0);
        }
        if(restart.triggered)
        {
            this.transform.position = new Vector3(0f,0f,transform.position.z);
        }
        if(end.triggered)
        {
            this.transform.position = new Vector3(1000f,0f,transform.position.z);
        }
    }
}
