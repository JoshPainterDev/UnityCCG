using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private string[] playerDeckList = new string[20];
    private string[] enemyDeckList = new string[20];

    public const int MAX_CARDS = 20;
    private Vector3 playerDeckLoc = new Vector3(-20,-7,0);
    private Vector3 enemyDeckLoc = new Vector3(-20, 7, 0);
    public GameObject card;


    // Use this for initialization
    void Start()
    {
        playerDeckList[0] = "Undead Abomination";
        playerDeckList[1] = "Undead Abomination";
        playerDeckList[2] = "Risen Fleshling";
        playerDeckList[3] = "Risen Fleshling";
        playerDeckList[4] = "UndeadAbomination";
        playerDeckList[5] = "UndeadAbomination";
        playerDeckList[6] = "Brigade Horseman";
        playerDeckList[7] = "Brigade Horseman";
        playerDeckList[8] = "Assassin Droid";
        playerDeckList[9] = "Assassin Droid";
        playerDeckList[10] = "SCR4P B0T";
        playerDeckList[11] = "SCR4P B0T";
        playerDeckList[12] = "Petty Theif";
        playerDeckList[13] = "Petty Theif";
        playerDeckList[14] = "UndeadAbomination";
        playerDeckList[15] = "UndeadAbomination";
        playerDeckList[16] = "UndeadAbomination";
        playerDeckList[17] = "UndeadAbomination";
        playerDeckList[18] = "UndeadAbomination";
        playerDeckList[19] = "UndeadAbomination";

        initializeDecks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void initializeDecks()
    {
        // spawn player deck
        for (int i = 0; i < MAX_CARDS; ++i)
        {
            GameObject spawnedCard = (GameObject)Instantiate(card, playerDeckLoc - new Vector3(i * 1f, 0, 0), transform.rotation);
            spawnedCard.GetComponent<ConstructCard>()._cardName = playerDeckList[i];
        }

        print("fuck me");

        // spawn opponent deck
        for (int i = 0; i < MAX_CARDS; ++i)
        {
            GameObject spawnedCard = (GameObject)Instantiate(card, enemyDeckLoc - new Vector3(i * 1f, 0, 0), transform.rotation);
            spawnedCard.GetComponent<ConstructCard>()._cardName = enemyDeckList[i];
        }
    }
}
