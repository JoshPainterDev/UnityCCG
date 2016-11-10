using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public const int MAX_CARDS = 20;
    private Vector3 playerDeckLoc = new Vector3(15,-7,0);
    private Vector3 enemyDeckLoc = new Vector3(15, 7, 0);
    public GameObject card;

    // Use this for initialization
    void Start()
    {
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
            GameObject spawnedCard = (GameObject)Instantiate(card, playerDeckLoc + new Vector3(i * 0.01f, 0, 0), transform.rotation);
        }

        // spawn opponent deck
        for (int i = 0; i < MAX_CARDS; ++i)
        {
            GameObject spawnedCard = (GameObject)Instantiate(card, enemyDeckLoc + new Vector3(i * 0.01f, 0, 0), transform.rotation);
        }
    }
}
