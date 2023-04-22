using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPicker : MonoBehaviour
{
    public AnimatorController[] animators;
    public AnimatorController officialAnimator;

    private void Start()
    {
        StartCoroutine(ShortDelay());
    }

    IEnumerator ShortDelay()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        for (int i = 0; i < animators.Length; i++)
        {
            if (animators[i].gameObject.activeSelf)
            {
                officialAnimator = animators[i];
            }
        }
    }
}
