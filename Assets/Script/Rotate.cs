using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	void Update () {
        Putar();
	}

    void Putar()
    {
        transform.Rotate(0, 0, 2);
    }
}
