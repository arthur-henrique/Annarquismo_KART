using Cinemachine.PostFX;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using KartGame.KartSystems;

public class PostProcessingManager : MonoBehaviour
{
    public static PostProcessingManager Instance;

    public CinemachineVolumeSettings volumeSettings;
    private ChromaticAberration aberration;
    private MotionBlur blur;
    private LensDistortion distortion;

    public ArcadeKart kart;
    public bool canProcess = true;

    // Constants to replace magic numbers
    private const float DRIFT_ABERRATION_INTENSITY = 0f;
    private const float DRIFT_BLUR_INTENSITY = 1f;
    private const float DRIFT_DISTORTION_INTENSITY = -0.2f;
    private const float NORMAL_ABERRATION_INTENSITY = 0f;
    private const float NORMAL_BLUR_INTENSITY = 0f;
    private const float NORMAL_DISTORTION_INTENSITY = 0f;
    private const float LERP_TIME = 3f;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        // Retrieve post-processing effects from volume settings
        if (volumeSettings.m_Profile.TryGet<ChromaticAberration>(out var tmp))
        {
            aberration = tmp;
        }

        if (volumeSettings.m_Profile.TryGet<MotionBlur>(out var tpmBlur))
        {
            blur = tpmBlur;
        }

        if (volumeSettings.m_Profile.TryGet<LensDistortion>(out var tpmDist))
        {
            distortion = tpmDist;
        }
    }

    private void Update()
    {
        if (kart.boostTime > 0f && canProcess)
        {
            canProcess = false;
            StartCoroutine(ApplyDriftEffect());
        }
    }

    private IEnumerator ApplyDriftEffect()
    {
        // Gradually adjust post-processing effects to create drift effect
        yield return StartCoroutine(LerpPostProcessingEffects(
            DRIFT_ABERRATION_INTENSITY, DRIFT_BLUR_INTENSITY, DRIFT_DISTORTION_INTENSITY));

        // Allow time for drift effect to play
        yield return new WaitForSeconds(kart.boostTime);

        // Gradually restore post-processing effects to normal values
        yield return StartCoroutine(LerpPostProcessingEffects(
            NORMAL_ABERRATION_INTENSITY, NORMAL_BLUR_INTENSITY, NORMAL_DISTORTION_INTENSITY));

        // Enable post-processing effects again
        canProcess = true;
    }

    private IEnumerator LerpPostProcessingEffects(float targetAberrationIntensity,
        float targetBlurIntensity, float targetDistortionIntensity)
    {
        float elapsed = 0f;
        float startAberrationIntensity = aberration.intensity.value;
        float startBlurIntensity = blur.intensity.value;
        float startDistortionIntensity = distortion.intensity.value;

        while (elapsed < LERP_TIME)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / LERP_TIME;

            aberration.intensity.value = Mathf.Lerp(startAberrationIntensity, targetAberrationIntensity, t);
            blur.intensity.value = Mathf.Lerp(startBlurIntensity, targetBlurIntensity, t);
            distortion.intensity.value = Mathf.Lerp(startDistortionIntensity, targetDistortionIntensity, t);

            yield return null;
        }
    }
}
