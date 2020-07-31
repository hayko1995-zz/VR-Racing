﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput.Native;
using WindowsInput;
using System;
using UnityEngine.EventSystems;

public class PressD : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    InputSimulator sim = new InputSimulator();
    private Boolean pressedD = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedD = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedD = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(pressedD == true)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_D);
        }
    }
}
