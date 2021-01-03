using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Variables
    private int cardsCount = 108;

    public List<Card> allCards, cardsInDeck, cardsOnBoard;

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

    #region draw card
    public void DrawCard(int _amount = 1)
    {
        //draw card

        //shuffle deck if needed
        if (cardsInDeck.Count < 2)
        {
            Shuffle();
        }
    }
    #endregion
    #region shuffle deck
    private void Shuffle()
    {
        int loop = cardsOnBoard.Count - 1; //affecting list so have to get count separately to loop through, leave last card
        for (int i = 0; i < loop; i++)
        {
            cardsInDeck.Add(cardsOnBoard[0]); //add to deck
            cardsOnBoard.RemoveAt(0); //remove from board
        }

        //randomise list
        RandomiseDeck();
    }
    #endregion
    #region randomise order
    /// <summary>
    /// Warning: contains untested nested loops, do not run.
    /// cardsInDeck is a list of cards.
    /// </summary>
    private void RandomiseDeck()
    {
        int[] _indexHolder = new int[cardsInDeck.Count]; //array of ints for indexing new order

        for (int i = 0; i < cardsInDeck.Count; i++) //for number of cards in deck
        {
            int _potentialIndex = Random.Range(0, cardsInDeck.Count - 1); //a random number for possible index

            bool _available = true; //default position is available

            foreach (int _index in _indexHolder) //for every position in array
            {
                if (_index == _potentialIndex) //if contains generated number
                {
                    _available = false; //position is no longer available
                }
            }

            if (_available) //if number passes position availability test
            {
                _indexHolder[i] = _potentialIndex; //set to position
            }
            else
            {
                i--; //try position over again with new number
            }
        }

        List<Card> _temp = cardsInDeck; //temp list of cards
        for (int i = 0; i < _indexHolder.Length; i++) //go through indices
        {
            _temp.Add(cardsInDeck[_indexHolder[i]]); //add card from old list to new index
        }
        cardsInDeck = _temp; //set deck to new ordered list
    }
    #endregion

    #region Testing
#if UNITY_EDITOR
    public void SHUFFLE()
    {
        Shuffle();
    }
    public void RANDOMISEDECK()
    {
        RandomiseDeck();
    }
#endif
    #endregion
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
    WildDrawFour,
    Wild,
}