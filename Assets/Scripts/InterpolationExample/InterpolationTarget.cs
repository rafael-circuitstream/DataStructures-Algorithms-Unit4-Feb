using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolationTarget : MonoBehaviour
{
    public float timer = 5;
    public Transform startingPoint;
    public Transform startingHandle;

    public Transform endingPoint;
    public Transform endingHandle;

    public float multiplication_A_C;
    public float multiplication_C_D;
    public float multiplication_D_B;
    public float start_Handle;
    public float endingPart;

    void Update()
    {
        timer += Time.deltaTime;
        float timerProgress = timer / 5f;

        // A_C is Starting point TO Starting Handle

        Vector3 a_c = Vector3.LerpUnclamped(startingPoint.position, startingHandle.position, timerProgress * 2f) * multiplication_A_C;
        Vector3 c_d = Vector3.Lerp(startingHandle.position, endingHandle.position, timerProgress) * multiplication_C_D;
        Vector3 d_b = Vector3.LerpUnclamped(endingHandle.position, endingPoint.position, timerProgress * 2f) * multiplication_D_B;
        Vector3 startToHandles = Vector3.Lerp(a_c, c_d, timerProgress) * start_Handle;

        Vector3 finalBezier = Vector3.Lerp(startToHandles, d_b, timerProgress) * endingPart;
        transform.position = finalBezier;
        if (timer >= 5) timer = 0f;
    }
}
