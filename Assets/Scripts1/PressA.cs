using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput.Native;
using WindowsInput;
using System;
using UnityEngine.EventSystems;

public class PressA : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    InputSimulator sim = new InputSimulator();
    private Boolean pressedA = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedA = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedA = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(pressedA == true)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
        }
    }

}
