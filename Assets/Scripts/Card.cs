using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject PiecePrefab;
    public Texture2D PieceSprite;

    public Player Player1;

    void Start()
    {

    }

    private void Update()
    {
        
    }

    public void SelectCard()
    {
        Player1.SetGameCursorMode(PieceSprite, GameCursorMode.Spawn);
    }

}
