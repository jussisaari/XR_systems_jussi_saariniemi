using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightChange : MonoBehaviour
{
    int colorIndex = 0;
    public InputActionReference action;
    public UnityEngine.Light light;
    public Color[] colors = new Color[4] {Color.red, Color.green, Color.blue, Color.white};
    void Start()
    {
        light = GetComponent<UnityEngine.Light>();
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) => {
            light.color = colors[colorIndex];
            colorIndex += 1;
            if (colorIndex > 3) {
                colorIndex = 0;
            }
        };
    }
}
