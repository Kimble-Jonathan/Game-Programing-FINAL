using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderSize : MonoBehaviour
{
    public Text SizeText;
    public  Slider SizeSlider;
    public static string SaveSize;

    public Text SizeText2;

    public void Update()
    {
        SizeText.text = SizeSlider.value.ToString();
        SaveSize = SizeSlider.value.ToString();
    }

    void Start()
    {
        SizeText2.text = SaveSize;
    }

}
