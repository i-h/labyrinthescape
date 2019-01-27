using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowAverage : MonoBehaviour {

    public Transform[] Targets;
    Vector3 _avgVec = new Vector2();
	
	// Update is called once per frame
	void Update () {
        _avgVec.x = 0;
        _avgVec.y = 0;
		foreach(Transform t in Targets)
        {
            _avgVec.x += t.position.x;
            _avgVec.y += t.position.y;
        }
        _avgVec /= Targets.Length;
        _avgVec.z = -2;


        transform.position = _avgVec;
	}
}
