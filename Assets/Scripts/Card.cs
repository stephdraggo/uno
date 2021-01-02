using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    #region Variables
    public CardManager manager;
    private CardColour colour;
    private CardValue cValue;
    #endregion
    #region Properties
    public CardColour Colour 
    { 
        get => colour;
        set
        {
            if (!manager.cardsInPlay.Contains(this))
            {
                colour = value;
            }
            else
            {
                Debug.LogError("colour already set for this card");
            }
        }
    }
    public CardValue Value 
    { 
        get => cValue;
        set
        {
            if (!manager.cardsInPlay.Contains(this))
            {
                cValue = value;
            }
            else
            {
                Debug.LogError("value already set for this card");
            }
        }
    }
    #endregion
    void Start()
    {
        manager = FindObjectOfType<CardManager>();
    }

    void Update()
    {
        
    }
}
