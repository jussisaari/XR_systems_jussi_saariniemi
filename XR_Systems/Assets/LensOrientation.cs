using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensOrientation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float parentZRotation = transform.parent.eulerAngles.z; 
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -parentZRotation);
    }
}
