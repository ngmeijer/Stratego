using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static float MoveX { get; private set; }
    public static float MoveZ { get; private set; }
    public static float MoveY { get; private set; }
    
    public static float LookHorizontal { get; private set; }
    public static float LookVertical { get; private set; }

    private void Update()
    {
        //Movement
        MoveX = Input.GetAxisRaw("Horizontal");
        MoveZ = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space)) MoveY = 1;
        else if (Input.GetKey(KeyCode.LeftControl)) MoveY = -1;
        else MoveY = 0;
        
        //Camera controls
        LookHorizontal = -Input.GetAxisRaw("Mouse Y");
        LookVertical = Input.GetAxisRaw("Mouse X");
    }
}
