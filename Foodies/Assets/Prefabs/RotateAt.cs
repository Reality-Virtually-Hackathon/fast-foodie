using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAt : MonoBehaviour {

    public Transform RotateAtCenter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(RotateAtCenter.position, Vector3.up, -90 * Time.deltaTime);
    }
}
