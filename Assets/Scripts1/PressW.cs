using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput.Native;
using WindowsInput;
using System;
using UnityEngine.EventSystems;

public class PressW : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    InputSimulator sim = new InputSimulator();
    private Boolean pressedW = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedW = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedW = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(pressedW == true)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_W);
        }
    }
}
