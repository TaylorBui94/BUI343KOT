using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class initGameBoard : MonoBehaviour
{   
    public GameObject myCanvas; // canvas placed into inspector
    public GameObject[] prefabsArray; // all players placed into inspector
    private List<GameObject> playerList; // desired, final player array
    private Vector3[] playerLocations; // use array
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        int playercount = numPlayers.playercount; // grab dropdown player count
        Debug.Log("playercount is " + playercount);
        List<GameObject> playerList = new List<GameObject>();
        // initialize player locations
        // set z float to 140 because myCanvas.transform subtracts 100 (why?!)
        Vector3[] playerLocations = new[] {new Vector3(-450f,240f,140f),
                                            new Vector3(-70f,240f,140f),
                                            new Vector3(280f,240f,140f),
                                            new Vector3(-430f,-280f,140f),
                                            new Vector3(-70,-280f,140f),
                                            new Vector3(300f,-280f,140f)};      
        for(int i = 0; i < playercount; i++) {
            // use Quaternion.identity for no rotation
            // add desired number of player objects to playerList, instantiate
            playerList.Add(Instantiate(prefabsArray[i], playerLocations[i], Quaternion.identity, myCanvas.transform));
        }
        // ding ding ding, this is how you get stuff from player objects!!!
        Debug.Log(playerList[0].gameObject.GetComponent<PlayerInfo>().getHP);
        playerList[0].gameObject.GetComponent<PlayerInfo>().setHP = 5;
        Debug.Log(playerList[0].gameObject.GetComponent<PlayerInfo>().getHP);
        Debug.Log(playerList[1].gameObject.GetComponent<PlayerInfo>().getHP);
        // we can use this transform position to place the InfoText textbox
        // in the correct location. we can also use a trigger to create/delete
        Debug.Log("Here is the transform of the player object: " + playerList[1].gameObject.transform.position);
        /*
        InfoText.text = "Health: " + HP.ToString() + 
                        "\nVictory Points: " + VP.ToString() +
                        "\nEnergy: " + energy.ToString();
        Instantiate(InfoText); // needs some work
        */
    }
}
