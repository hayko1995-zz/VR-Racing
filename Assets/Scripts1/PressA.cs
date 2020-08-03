// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using WindowsInput.Native;
// using WindowsInput;
// using System;
// using UnityEngine.EventSystems;

// public class PressA : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
// {

//     InputSimulator sim = new InputSimulator();
//     private Boolean pressedA = false;

//     public void OnPointerDown(PointerEventData eventData)
//     {
//         //throw new NotImplementedException();
//         pressedA = true;
//     }

//     public void OnPointerUp(PointerEventData eventData)
//     {
//         //throw new NotImplementedException();
//         pressedA = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//       if(pressedA == true)
//         {
//             sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
//         }
//     }

// }

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleInputNamespace
{
	public class PressA : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		public SimpleInput.AxisInput axis = new SimpleInput.AxisInput();
		public float value = 1f;

		private void Awake()
		{
			Graphic graphic = GetComponent<Graphic>();
			if( graphic != null )
				graphic.raycastTarget = true;
		}

		private void OnEnable()
		{
			axis.StartTracking();
		}

		private void OnDisable()
		{
			axis.StopTracking();
		}

		public void OnPointerDown( PointerEventData eventData )
		{
			axis.value = value;
		}

		public void OnPointerUp( PointerEventData eventData )
		{
			axis.value = 0f;
		}
	}
}