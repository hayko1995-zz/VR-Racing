// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using WindowsInput.Native;
// using WindowsInput;
// using System;
// using UnityEngine.EventSystems;

// public class PressS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
// {

//     InputSimulator sim = new InputSimulator();
//     private Boolean pressedS = false;

//     public void OnPointerDown(PointerEventData eventData)
//     {
//         //throw new NotImplementedException();
//         pressedS = true;
//     }

//     public void OnPointerUp(PointerEventData eventData)
//     {
//         //throw new NotImplementedException();
//         pressedS = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//       if(pressedS == true)
//         {
//             sim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
//         }
//     }
// }



using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleInputNamespace
{
	public class PressS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		public SimpleInput.AxisInput axis = new SimpleInput.AxisInput();
		public float value = 1f;

		private void Awake()
		{
			// Graphic graphic = GetComponent<Graphic>();
			// if( graphic != null )
			// 	graphic.raycastTarget = true;
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