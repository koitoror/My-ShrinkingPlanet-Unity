using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text fpsText;
    private float pollingTime = 1f; // Sample time
    private float elapsedTime;
    private int frameCount; // Measure number of frames that have passed

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        frameCount++;
        if(elapsedTime >= pollingTime){
            int frameRate = Mathf.RoundToInt(frameCount/elapsedTime);
            fpsText.text = frameRate.ToString() + " FPS";

            // Reset
            elapsedTime -= pollingTime;
            frameCount = 0;
        }
    }
}
