using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMainCamera : MonoBehaviour
{
	// ReSharper disable Unity.PerformanceAnalysis
	private void Update()
	{
		//ライフゲージが相手のカメラを向く
		if (Camera.main != null) 
			transform.LookAt(Camera.main.transform); 
	}
}