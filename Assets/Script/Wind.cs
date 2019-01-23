using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wind : MonoBehaviour {

    public Slider m_Slider;
    public Text windValue;
    public Text windResult;
    public GameObject m_Image;
    public bool clockWise, unclockWise;

    // Use this for initialization
    void Start () {
        clockWise = false;
        unclockWise = true;
    }
	
	// Update is called once per frame
	void Update () {
        float degreeValue = 360 * m_Slider.value;
        windValue.text = degreeValue.ToString();
        m_Image.transform.eulerAngles = new Vector3(0, 0, -degreeValue);

        if (degreeValue >= 0 && degreeValue < 180)
        {
            windResult.text = "Right";
            clockWise = false;
            unclockWise = true;
        }
        else if (degreeValue >= 180 && degreeValue <=360)
        {
            windResult.text = "Left";
            clockWise = true;
            unclockWise = false;
        }
	}
}
