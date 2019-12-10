using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toggle : MonoBehaviour
{

    public Toggle EnablePlay;
    public GameObject PlayButton;
    public void Toggle_Change(bool newValue)
    {
        PlayButton.SetActive(newValue);
    }
    private void Start()
    {
        PlayButton.SetActive(false);
    }
}
