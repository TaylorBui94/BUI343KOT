using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class VolumeSlider : MonoBehaviour
{
    private GameObject sourceObject;
    private AudioSource source; // component of sourceObject
    // Start is called before the first frame update

    void Start() {
        // Retrieve active game object with tag
        sourceObject = GameObject.FindWithTag("Tag_AudioSource");
        // Retrieve component of type AudioSource
        source = sourceObject.GetComponent<AudioSource>();
        // check if correct source retrieved and assert if ANY source found
        Debug.Log("here is your AudioSource: " + source);
        Assert.IsNotNull(source);
    }
    
    // Function is tied to the OnValueChange function built into the Slider.
    // Takes volumeSlider UI object as an argument from which we derive the 
    // slider value
    public void SliderToVol(Slider volumeSlider) {
        source.volume = volumeSlider.value;
    }

    // YVAN EHT NOIJ!
    public void SliderToPitch(Slider pitchSlider) {
        source.pitch = pitchSlider.value;
    }

    // Don't join the navy?
    public void SliderResetPitch(Slider pitchSlider) {
        pitchSlider.value = 1;
        source.pitch = 1;
    }
}
