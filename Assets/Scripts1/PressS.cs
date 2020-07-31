using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput.Native;
using WindowsInput;
using System;
using UnityEngine.EventSystems;

public class PressS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    InputSimulator sim = new InputSimulator();
    private Boolean pressedS = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedS = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        pressedS = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(pressedS == true)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
        }
    }
}
