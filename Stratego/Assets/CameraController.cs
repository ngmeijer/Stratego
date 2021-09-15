using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 90f;
    
    private void Update()
    {
        transform.eulerAngles += new Vector3(InputManager.LookHorizontal, InputManager.LookVertical, 0) * (rotateSpeed * Time.deltaTime);
    }
}