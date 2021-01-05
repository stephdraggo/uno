using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//parent class for player and AI hands

public class HandBase : MonoBehaviour
{
    #region Variables
    [SerializeField] private List<Card> cards;
    public Card lastCardPlayed;
    #endregion
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>
    /// this method gets called by turn manager
    /// </summary>
    public void MyTurn()
    {
        //check lastCardPlayed for harmful effect
        PlayableCards();

        CheckWin();
    }

    private void PlayableCards()
    {
        //go through cards and compare to lastCardPlayed

        //if no cards playable, draw cards
    }
    private void CheckWin()
    {
        if (cards.Count < 1)
        {
            Debug.Log(this + " wins");
        }
        else if (cards.Count ==1)
        {
            Debug.Log(this + " gets uno");
        }
    }
    #region card specific mechanics
    private void PowerCardEffect()
    {
        switch (lastCardPlayed.Value)
        {
            #region number cards
            case CardValue.Zero:
                break;
            case CardValue.One:
                break;
            case CardValue.Two:
                break;
            case CardValue.Three:
                break;
            case CardValue.Four:
                break;
            case CardValue.Five:
                break;
            case CardValue.Six:
                break;
            case CardValue.Seven:
                break;
            case CardValue.Eight:
                break;
            case CardValue.Nine:
                break;
            case CardValue.Ten:
                break;
            #endregion
            case CardValue.Reverse:
                break;
            case CardValue.Skip:
                break;
            case CardValue.DrawTwo:
                break;
            case CardValue.WildDrawFour:
                break;
            case CardValue.Wild:
                break;
            default:
                break;
        }
    }
    #endregion
}
