using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numPlayers : MonoBehaviour
{
    // initialize global playercount to 2 players
    public static int playercount = 2;
    
    public void updateNumPlayers(Dropdown dd) {
     // Want 2-6 players, but .value returns index starting at 0.
     // We just add 2 in order to get the correct number of players
        playercount = dd.value + 2;
        Debug.Log("The number of players is: " + playercount);
    }
}
