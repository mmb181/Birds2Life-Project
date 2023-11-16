using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RobinScaleRotate : MonoBehaviour
{
    // Public variables for slider references and min/max values
    public Slider scaleSlider;
    public Slider rotateSlider;
    public float scaleMinValue = 0.5f;
    public float scaleMaxValue = 20.0f;
    public float rotMinValue = 0f;
    public float rotMaxValue = 360f;

    void ScaleSliderUpdate(float value)
    {
        // Clamp scale value to the maximum value
        float clampedScaleValue = Mathf.Clamp(value, 0f, scaleMaxValue);

        // Apply the clamped scale value
        transform.localScale = new Vector3(clampedScaleValue, clampedScaleValue, clampedScaleValue);
    }

    void RotateSliderUpdate(float value)
    {
        // Apply rotation by multiplying the slider value by a factor
        transform.localEulerAngles = new Vector3(transform.rotation.x, value * 1f, transform.rotation.z);
    }




    void Start()
    {
        // Initialize sliders with min/max values and event listeners
        scaleSlider = GameObject.Find("ScaleSlider5").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;
        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        rotateSlider = GameObject.Find("RotateSlider5").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;
        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
    }

}
