using UnityEngine;
using UnityEngine.XR;

public class AntiAliasing : MonoBehaviour
{
    private void Awake()
    {
        XRSettings.eyeTextureResolutionScale = 2.0f;
    }
}
