using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Transform RoomView;
    public Transform ExternalView;
    public Transform[] positions;
    void Start()
    {
       positions = new Transform[] {RoomView, ExternalView};
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) => {
            if (transform.position == positions[0].position) {
                transform.position = positions[1].position;
            } else {
                transform.position = positions[0].position;
            }
        };
    }
}
