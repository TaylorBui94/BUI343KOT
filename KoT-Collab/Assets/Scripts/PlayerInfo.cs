using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]
    
    private int HP; // health points
    private int VP; // victory points
    private int energy;
    
    //0 = out
    // 1 = in tokyo
    // 2 = intokyo bay
    private int location; 

    // implement inTokyoBay later?
    // more attributes needed upon card implementation

    // Start is called before the first frame update
    void Awake()
    {
        HP = 20;
        VP = 0;
        energy = 0;
        location = 0;
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


    public void gainHearts(int gain)
    {
        HP += gain;
        //if overmaxed
        if(HP > 20 ) HP = 20;
    }

    public void loseHearts(int loss)
    {
        HP -= loss;
        //if overmaxed
        if(HP <= 0) playerDeath();
    }

    public void gainEnergy(int gain)
    {
        energy += gain;
    }

    public void loseEnergy(int loss)
    {
        energy -= loss;
    }
     public void gainVP(int gain)
    {
        VP += gain;
    }

    public void loseVP(int loss)
    {
        VP -= loss;
    }


    void playerDeath()
    {
        
    }



    // maybe add functions for adding and removing values? yes

    // Update is called once per frame
    // This is hacky and potentially detrimental  to performance
    // If necessary, only change text when values are changed
    // It definitely displays the current HP, VP, energy of the player properly
    void Update()
    {
        GetComponentInChildren<TextMeshProUGUI>().text = "Health: " + HP +
                                                         "\nVP: " + VP +
                                                         "\nEnergy: " + energy;
    }
}
