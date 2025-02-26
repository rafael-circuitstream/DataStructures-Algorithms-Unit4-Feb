using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InterpolationExample : MonoBehaviour
{
    public float timer;
    public float number;

    public Vector3 lerpedVector;

    public Color startingColor;
    public Color maxColor;
    public Color lerpedColor;

    [Range(0, 1f)] public float handle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region Float_Lerp
        timer += Time.deltaTime;

        number = Mathf.Lerp(10, 50, timer / 5f);
        #endregion

        lerpedColor = Color.Lerp(startingColor, maxColor, handle);


        lerpedVector = Vector3.Lerp(new Vector3(10, 2, 5), new Vector3(32, 7, 49), handle);
        

    }

}
