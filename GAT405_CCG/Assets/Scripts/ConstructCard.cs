using UnityEngine;
using System.Collections;

public class ConstructCard : MonoBehaviour
{
    [HideInInspector]
    public enum Cards { Catalyst, Aura, Initiative, Pawn, Legend, Trap, None }
    public enum Faction { Red, Blue, Green, Purple, Black, None }

    public int MaxDeckSize = 20;
    [HideInInspector]
    public string _cardName = "";
    [HideInInspector]
    public Cards _cardType;
    [HideInInspector]
    public int _attack;
    [HideInInspector]
    public int _health;
    [HideInInspector]
    public string _cardText;
    [HideInInspector]
    public string _cardTribe = "";
    [HideInInspector]
    public Color _cardFaction = Color.clear;
    [HideInInspector]
    public int _cardCost = 0;

    private Color purple = new Color(0.57f, 0f, 0.84f, 1);

    // Use this for initialization
    void Start ()
    {
        setCardInfo(_cardName);
        setUpImages();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void setUpImages()
    {
        GameObject factionColor = transform.FindChild("FactionColor").gameObject;
        factionColor.GetComponent<SpriteRenderer>().color = _cardFaction;
    }

    public void setCardInfo(string cardName)
    {
        switch (cardName)
        {
            // Pawns
            case "Undead Abomination":
                _attack = 2;
                _health = 2;
                _cardCost = 2;
                _cardText = "Death Charge: Discard 1 of your Opponent's active Trap cards when attacking, then discard this card.";
                _cardTribe = "Pawn";
                _cardFaction = Color.green;
                break;
            case "Risen Fleshling":
                _attack = 1;
                _health = 1;
                _cardCost = 1;
                _cardText = " ";
                _cardTribe = "Pawn";
                _cardFaction = Color.green;
                break;
            case "Brigade Horseman":
                _attack = 3;
                _health = 3;
                _cardCost = 2;
                _cardText = " ";
                _cardTribe = "Pawn";
                _cardFaction = Color.blue;
                break;
            case "Wounded Soldier":
                _attack = 2;
                _health = 1;
                _cardCost = 1;
                _cardText = " ";
                _cardTribe = "Pawn";
                _cardFaction = Color.blue;
                break;
            case "Assassin Droid":
                _attack = 4;
                _health = 2;
                _cardCost = 3;
                _cardText = "Programmed Precision: This minion doesn't take damage when attacking.";
                _cardTribe = "Pawn";
                _cardFaction = Color.red;
                break;
            case "SCR4P B0T":
                _attack = 1;
                _health = 3;
                _cardCost = 1;
                _cardText = " ";
                _cardTribe = "Pawn";
                _cardFaction = Color.red;
                break;
            case "Petty Theif":
                _attack = 1;
                _health = 1;
                _cardCost = 1;
                _cardText = "Street Wealth: ";
                _cardTribe = "Pawn";
                _cardFaction = Color.black;
                break;
            case "Silverblood Rogue":
                _attack = 3;
                _health = 2;
                _cardCost = 2;
                _cardText = "Payout: draw a card when this Pawn defeats an enemy.";
                _cardTribe = "Pawn";
                _cardFaction = Color.black;
                break;

            // Catalysts
            case "Small Sacrifise":
                _attack = 0;
                _health = 0;
                _cardCost = 0;
                _cardText = "Sacrifise: Discard a Pawn from your hand, Draw 1 (+1) card(s).";
                _cardTribe = "Catalyst";
                _cardFaction = Color.green;
                break;
            case "Soul Siphon":
                _attack = 0;
                _health = 0;
                _cardCost = 0;
                _cardText = "Sacrifise: Discard a Pawn from your hand, Draw 1 (+1) card(s).";
                _cardTribe = "Catalyst";
                _cardFaction = Color.green;
                break;

            // Auras
            case "Holy Divination":
                _attack = 0;
                _health = 0;
                _cardCost = 2;
                _cardText = "Aura: +1 Attack to all Blue units.";
                _cardTribe = "Aura";
                _cardFaction = Color.blue;
                break;
            case "Graveyard":
                _attack = 0;
                _health = 0;
                _cardCost = 3;
                _cardText = "Aura: Catalyst Sacrifises cost 1 less.";
                _cardTribe = "Aura";
                _cardFaction = Color.green;
                break;
            case "Synthetic Terrain":
                _attack = 0;
                _health = 0;
                _cardCost = 4;
                _cardText = "Aura: +1/+1 Attack to all red Pawns.";
                _cardTribe = "Aura";
                _cardFaction = Color.red;
                break;
            case "Shadow Mist":
                _attack = 0;
                _health = 0;
                _cardCost = 3;
                _cardText = "Aura: Spend 2 Resources. Stealth your Black Pawns for this turn.";
                _cardTribe = "Aura";
                _cardFaction = Color.black;
                break;
            case "Shifting Sands":
                _attack = 0;
                _health = 0;
                _cardCost = 3;
                _cardText = "Aura: Spend 2 Resources. Stealth your Black Pawns for this turn.";
                _cardTribe = "Aura";
                _cardFaction = purple;
                break;

            default:
                break;
        }
    }

    class CardInfo
    {
        Cards cardType = Cards.None;
    }
}
