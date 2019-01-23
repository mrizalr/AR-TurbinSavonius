using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeCamera : MonoBehaviour {

    bool cameramode = false;
    public void OnCameraChangeMode()
    {
        Vuforia.CameraDevice.CameraDirection currentDir = Vuforia.CameraDevice.Instance.GetCameraDirection();
        if (!cameramode)
        {
            RestartCamera(Vuforia.CameraDevice.CameraDirection.CAMERA_FRONT);
            Debug.Log("Using FRONT Camera");
        }
        else
        {
            RestartCamera(Vuforia.CameraDevice.CameraDirection.CAMERA_BACK);
            Debug.Log("Using BAC Camera");
        }
    }

    private void RestartCamera(Vuforia.CameraDevice.CameraDirection newDir)
    {
        Vuforia.CameraDevice.Instance.Stop();
        Vuforia.CameraDevice.Instance.Deinit();
        Vuforia.CameraDevice.Instance.Init(newDir);
        Vuforia.CameraDevice.Instance.Start();
    }
}
