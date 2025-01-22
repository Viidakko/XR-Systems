using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    private bool inside = true;


    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (inside)
            {
                transform.position = transform.position + new Vector3(0, 0, -20);
                inside = false;
            } 
            else
            {
                transform.position = transform.position + new Vector3(0, 0, 20);
                inside = true;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
