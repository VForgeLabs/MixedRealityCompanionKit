using System.Collections;
using System.Collections.Generic;
using MixedRemoteViewCompositor;
using UnityEngine;

public class CameraMatricesTest : MonoBehaviour {

	[SerializeField] MrvcManager _manager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CameraMatrices matrices = new CameraMatrices();
		if(_manager.TryGetCaptureCameraMatrices(ref matrices))
		{
            if (matrices.IsSet)
            {
                Debug.LogFormat(this, "[CameraMatricesTest] - We should have valid matrices");
            }
            else
            {
                Debug.LogFormat(this, "[CameraMatricesTest] - Got matrices, but NOT IsSet!!!");
            }
        }
	}
}
