using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindRotate : MonoBehaviour {

    [SerializeField]
    private Wind windScript;
    [SerializeField]
    private RPM rpmScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (windScript.unclockWise)
        {
            transform.Rotate(0, 0, -rpmScript.rpmValue_);
        }
        else if (windScript.clockWise)
        {
            transform.Rotate(0, 0, rpmScript.rpmValue_);
        }
	}
}
