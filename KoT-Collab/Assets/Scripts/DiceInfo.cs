using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceInfo : MonoBehaviour
{
    private Image myImageComponent;
    public int DiceNumber;
    private int DiceValue;
    private bool isClicked;
    public Sprite originalImage;
    public Sprite OneFace;
    public Sprite TwoFace;
    public Sprite ThreeFace;
    public Sprite HeartFace;
    public Sprite EnergyFace;
    public Sprite SmashFace;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        myImageComponent.sprite = originalImage;
    }
/*
    public void SetDiceValue() {
        DiceValue = GetComponentInParent<Dice>().GetDiceValue(DiceNumber);
        Debug.Log("DiceValue of die: " + DiceNumber + " is " + DiceValue);
    }*/

    public void GetDiceFace() {
        DiceValue = transform.parent.GetComponent<Dice>().getDiceValue(DiceNumber);
        //Debug.Log("here is the dicevalue: " + DiceValue);
        myImageComponent = GetComponent<Image>();
        if (DiceValue == 1) myImageComponent.sprite = OneFace;  
        if (DiceValue == 2) myImageComponent.sprite = TwoFace;
        if (DiceValue == 3) myImageComponent.sprite = ThreeFace;
        if (DiceValue == 4) myImageComponent.sprite = HeartFace;
        if (DiceValue == 5) myImageComponent.sprite = EnergyFace;
        if (DiceValue == 6) myImageComponent.sprite = SmashFace;
    }
    


    // Update is called once per frame
    void Update()
    {
        GetDiceFace();
    }
}
