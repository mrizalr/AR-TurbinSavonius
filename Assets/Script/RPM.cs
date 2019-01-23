using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPM : MonoBehaviour {

    public Slider rpmSlider;
    public Text rpmValue;
    public Text fov_Value;
    public float rpmValue_;

	// Use this for initialization
	void Start () {
        rpmValue.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        rpmValue_ = 100 * rpmSlider.value;
        rpmValue.text = rpmValue_.ToString();
        fov_Value.text = Camera.main.pixelRect.ToString();
    }
}
