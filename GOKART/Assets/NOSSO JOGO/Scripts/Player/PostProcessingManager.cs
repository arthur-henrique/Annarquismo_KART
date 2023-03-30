using Cinemachine.PostFX;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using KartGame.KartSystems;
using JetBrains.Annotations;

public class PostProcessingManager : MonoBehaviour
{
    public static PostProcessingManager Instance;
    public CinemachineVolumeSettings volumeSettings;
    private ChromaticAberration aberration;
    private MotionBlur blur;
    private LensDistortion distortion;
    public ArcadeKart kart;

    public bool canProcess = true;

    //public Vector3 intensityValue


    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        ChromaticAberration tmp;
        if (volumeSettings.m_Profile.TryGet<ChromaticAberration>(out tmp))
        {
            aberration = tmp;
            //aberration.intensity = new ClampedFloatParameter(0f, 0f, 1f, true);
        }

        MotionBlur tpmBlur;
        if (volumeSettings.m_Profile.TryGet<MotionBlur>(out tpmBlur))
        {
            blur = tpmBlur;
            //blur.intensity = new ClampedFloatParameter(0f, 0f, 1f, true);
        }

        LensDistortion tpmDist;
        if (volumeSettings.m_Profile.TryGet<LensDistortion>(out tpmDist))
        {
            distortion = tpmDist;
            //distortion.intensity = new ClampedFloatParameter(0f, -1f, 1f, true);
        }

    }

    private void Update()
    {
        if (kart.boostTime > 0f && canProcess)
        {
            canProcess = false;
            DriftVolumeSettings();
            print("VolumeOn");
            
        }
    }

    IEnumerator NormalVolumeSettings()
    {
        yield return new WaitForSeconds(kart.boostTime);
        aberration.intensity.value = Mathf.Lerp(0.3f, 0f, 10f);
        blur.intensity.value = Mathf.Lerp(1f, 0f, 10f);
        blur.active = false;
        distortion.intensity.value = Mathf.Lerp(-0.2f, 0f, 10f);
        canProcess = true;
        

    }

    void DriftVolumeSettings()
    {
        StartCoroutine(NormalVolumeSettings());
        //aberration.intensity.value = Mathf.Lerp(0f, 3f, 10f);
        blur.intensity.value = Mathf.Lerp(0f, 1f, 10f);
        blur.active = true;
        distortion.intensity.value = Mathf.Lerp(0f, -0.2f, 10f);
    }
}
