using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    private bool redOn = false;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (redOn == false)
            {
                light.color = Color.red;
                redOn = true;
            }
            else
            {
                light.color = Color.white;
                redOn = false;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
