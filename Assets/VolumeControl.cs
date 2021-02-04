using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    [DllImport("VolumeControlDll")]
    public static extern bool GetMasterMute();

    [DllImport("VolumeControlDll")]
    public static extern float GetApplicationVolume(int pid);
    [DllImport("VolumeControlDll")]
    public static extern bool GetApplicationMute(int pid);
    [DllImport("VolumeControlDll")]
    public static extern void SetMasterVolume(float level);
    [DllImport("VolumeControlDll")]
    public static extern void SetMasterMute(bool mute);
    [DllImport("VolumeControlDll")]
    public static extern void SetApplicationVolume(int pid, float level);
    [DllImport("VolumeControlDll")]
    public static extern void SetApplicationMute(int pid, bool mute);

    [DllImport("VolumeControlDll")]
    public static extern float GetMasterVolume();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("current volume:" + GetMasterVolume());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SetMasterVolume(GetMasterVolume() - 1);
            Debug.Log("sub vulume:" + GetMasterVolume());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SetMasterVolume(GetMasterVolume() + 1);
            Debug.Log("increase volume :" + GetMasterVolume());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SetMasterMute(!GetMasterMute());
            Debug.Log("mute state:" + GetMasterVolume());
        }
    }
}
