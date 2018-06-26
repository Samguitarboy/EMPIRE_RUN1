using UnityEngine;
using System.Collections;
using Vuforia;

public class CameraMode : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        VuforiaARController.Instance.RegisterOnPauseCallback(OnPaused);
    }

    void Update()
    {

    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused)
        { // resumed
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}

作者：楼上小宇
链接：https://www.jianshu.com/p/794bec23f66a
來源：简书
简书著作权归作者所有，任何形式的转载都请联系作者获得授权并注明出处。