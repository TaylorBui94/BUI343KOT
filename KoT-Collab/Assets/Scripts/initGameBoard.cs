using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions;

public class initGameBoard : MonoBehaviour
{   
    [SerializeField]
    public GameObject myCanvas; // canvas placed into inspector
    // all player prefabs put are in inspector
    // these will be used to create the actual playerList
    private GameObject EscMenu;
    public GameObject[] prefabsArray;
    private static List<GameObject> playerList; // desired, final player array
    private Vector3[] playerLocations; // use array to set player spawn location

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        int playercount = numPlayers.playercount; // grab dropdown player count
        Debug.Log("playercount is " + playercount);
        List<GameObject> playerList = new List<GameObject>();
        // initialize player locations
        // set z float to 140 because myCanvas.transform subtracts 100 (why?!)
        
        Vector3[] playerLocations = new[] {new Vector3(-510.0f,266.0f,140.0f),
                                            new Vector3(-150.0f,266.0f,140.0f),
                                            new Vector3(170.0f,266.0f,140.0f),
                                            new Vector3(-510.0f,-266.0f,140.0f),
                                            new Vector3(-150.0f,-266.0f,140.0f),
                                            new Vector3(170.0f,-266.0f,140.0f)};
        for(int i = 0; i < playercount; i++) {
            // use Quaternion.identity for no rotation
            // add desired number of player objects to playerList, instantiate
            // myCanvas.transform to set players as children of myCanvas
            playerList.Add(Instantiate(prefabsArray[i], playerLocations[i], Quaternion.identity, myCanvas.transform));
            Debug.Log("Here is the player name: " + playerList[i].name);
        }

        // Add an assertion test to check if length of playerList = playercount
        // throws exception if playercount is not equal to # of players in list
        Assert.AreEqual(playercount, playerList.Count);
        // ding ding ding, this is how you get stuff from player objects!!!
        //Debug.Log(playerList[0].gameObject.GetComponent<PlayerInfo>().getHP);
        //playerList[0].gameObject.GetComponent<PlayerInfo>().setHP = 5;
        //Debug.Log(playerList[0].gameObject.GetComponent<PlayerInfo>().getHP);
        //Debug.Log(playerList[1].gameObject.GetComponent<PlayerInfo>().getHP);

        // we can use this transform position to place the InfoText textbox
        // in the correct location. we can also use a trigger to create/delete
        // (but I found a better way).

        /* Don't do this
        InfoText.text = "Health: " + HP.ToString() + 
                        "\nVictory Points: " + VP.ToString() +
                        "\nEnergy: " + energy.ToString();
        Instantiate(InfoText); // needs some work
        */
    }

    public GameObject getPlayer(int index) {
        return playerList[index];
    }

    void Update() {
            
    }
}
