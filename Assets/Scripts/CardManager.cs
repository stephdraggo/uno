using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    #region Variables
    private int cardsCount = 108;

    public List<Card> cardsInPlay;

    public GameObject cardPrefab;
    #endregion

    void Start()
    {
        #region Spawn Cards
        for (int i = 0; i < cardsCount; i++)
        {
            GameObject newCard = Instantiate(cardPrefab);
            
        }
        #endregion
    }

    void Update()
    {

    }
}

public enum CardColour
{
    Red,
    Blue,
    Yellow,
    Green,
    NonColour,
}

public enum CardValue
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Reverse,
    Skip,
    DrawTwo,
    DrawFour,
    ChangeColour,
}