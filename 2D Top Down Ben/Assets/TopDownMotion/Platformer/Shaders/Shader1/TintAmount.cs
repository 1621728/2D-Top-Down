using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintAmount : MonoBehaviour
{
    // Start is called before the first frame update

    public float tintAmount;
    public Material tintMat;
    
    // Update is called once per frame 
    void Update()
    {
        tintAmount = Mathf.Lerp(tintAmount, 0, Time.deltaTime);
        tintAmount = Mathf.Clamp(tintAmount, 0, 1);
        tintMat.SetFloat("Vector1", tintAmount);


    }
}
