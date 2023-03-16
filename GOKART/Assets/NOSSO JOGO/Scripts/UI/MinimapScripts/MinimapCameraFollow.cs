using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraFollow : MonoBehaviour
{
    [SerializeField] private MinimapSettings settings;
    [SerializeField] private float cameraHeigth;

    private void Awake()
    {
        settings = GetComponentInParent<MinimapSettings>();
        cameraHeigth = transform.position.y;
    }
    private void Update()
    {
        Vector3 targetPosition
            = settings.targetToFollow.transform.position;
        transform.position
            = new Vector3(
                targetPosition.x,
                targetPosition.y + cameraHeigth,
                targetPosition.z);
        if (settings.rotatewithTheTarget)
        {
            Quaternion targetRotation
                = settings.targetToFollow.transform.rotation;
            transform.rotation
                = Quaternion.Euler(
                    90,
                    targetRotation.eulerAngles.y,
                    0);
        }
    }
}
