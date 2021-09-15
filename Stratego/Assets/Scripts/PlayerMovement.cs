using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
    private void Update()
    {
        Vector3 moveVector = new Vector3(InputManager.MoveX, InputManager.MoveY, InputManager.MoveZ).normalized;
        transform.Translate(moveVector * (moveSpeed * Time.deltaTime));
    }
}
