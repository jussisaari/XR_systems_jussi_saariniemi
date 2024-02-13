using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOrientation : MonoBehaviour
{
    public Transform playerEyes;
    public Transform lens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 directionToLens = lens.position - playerEyes.position;
        transform.rotation = Quaternion.LookRotation(directionToLens);
    }
}
