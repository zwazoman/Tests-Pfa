using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] Transform _cam;
    private void Update()
    {
        transform.LookAt(transform.position + _cam.forward);
    }
}
