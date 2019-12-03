using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    // we can probably also add a text box here to display
    // info assuming the player is still alive
    [SerializeField]
    private Text InfoText;
    private int HP; // health points
    private int VP; // victory points
    private int energy;
    // more attributes needed upon card implementation
    // Start is called before the first frame update
    void Awake()
    {
        HP = 20;
        VP = 0;
        energy = 0;
        InfoText.text = "Health: " + HP.ToString() + 
                        "\nVictory Points: " + VP.ToString() +
                        "\nEnergy: " + energy.ToString();
        Instantiate(InfoText); // needs some work
    }
    // For the sake of clarity, java style setters and getters are used
    // Getters
    public int getHP {get {return HP;}}
    public int getVP {get {return VP;}}
    public int getEnergy {get {return energy;}}
    // Setters do we need these? maybe
    public int setEnergy {set {energy = value;}}
    public int setHP {set {HP = value;}}
    public int setVP {set {VP = value;}}
    // maybe add functions for adding and removing values?
    // Update is called once per frame
    void Update()
    {
        
    }
}
