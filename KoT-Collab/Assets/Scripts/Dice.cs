using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dice : MonoBehaviour
{

    private static int[] dice; // set as static
    private static bool[] rerollFlag;
    // Start is called before the first frame update

    void Start()
    {
        dice  = new int[6]{ 0,0,0,0,0,0};
        rerollFlag = new bool[6]{ true,true,true,true,true,true};
    }

    public void rollDice()
    {
        //adding 1 removes out of bound
    
        for(int i = 0; i < 6; i++)
        {
            if(rerollFlag[i] == true)
            {
                dice[i] = Random.Range(1, 7);
                rerollFlag[i] = false;
                //Debug.Log(dice.Count );
                Debug.Log(dice[i]);
            }
        } 
    }

    public int getDiceValue(int diceNumber) {
        return dice[diceNumber-1];
    }

    public void setDiceFlag0()
    {
        if(rerollFlag[0] == true) rerollFlag[0] = false;
        else  rerollFlag[0] = true;
    }

       public void setDiceFlag1()
    {
        if(rerollFlag[1] == true) rerollFlag[1] = false;
        else  rerollFlag[1] = true;
    }

        public void setDiceFlag2()
    {
        if(rerollFlag[2] == true) rerollFlag[2] = false;
        else  rerollFlag[2] = true;
    }

    public void setDiceFlag3()
    {
        if(rerollFlag[3] == true) rerollFlag[3] = false;
        else  rerollFlag[3] = true;
    }


    public void setDiceFlag4()
    {
        if(rerollFlag[4] == true) rerollFlag[4] = false;
        else  rerollFlag[4] = true;
    }

    public void setDiceFlag5()
    {
        if(rerollFlag[5] == true) rerollFlag[5] = false;
        else  rerollFlag[5] = true;
    }


/*    
    public int GetDiceValue(int diceNumber) {
        // returns value of the specified dice
        return dice[diceNumber - 1];
    }
    */

/*
    void ResolveDice()
    {

    for(; dice.Count<6;)
{}

}
*/

//not finished until we have the other functions
    public void ResolveDice()
    {
        Debug.Log("RESOLVE DICE INSIDE");
        int[] sumOfDice = new int[6]{0,0,0,0,0,0};
   
        for(int i = 0; i < 6; i++)
        {
            
            if(dice[i] == 1) sumOfDice[0]++;
            if(dice[i] == 2) sumOfDice[1]++;
            if(dice[i] == 3) sumOfDice[2]++;
            if(dice[i] == 4) sumOfDice[3]++;
            if(dice[i] == 5) sumOfDice[4]++;
            if(dice[i] == 6) sumOfDice[5]++;      
        }

        //resolve 1-3
        for(int i = 0; i < 3; i++)
        {
            if(sumOfDice[i] > 0)
            {
                int total = i + 1 + (sumOfDice[i]-3);
                //GameObject currentPlayer = GameObject.FindWithTag("MainCanvas").GetComponent<initGameBoard>().getPlayer(0);
                
                //playerlist[1]
              //  playerList[1].name.gainVP(total);
                //gainVP(total);
                //VP Update(total);s
            }
        }

        //resolve 4-6 heart, energy, smash
        
        // HP 
        // Player.Update.HP(sumOfDice[3])

         // energy 
          // Player.Update.energy(sumOfDice[4])

          // smash resolesumOfDice[5];
          // smash(sumOfDice[5])

            
    }
}
