using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameHandler Handler;
    public Texture2D RookSpr;
    string Type;

    void Start()
    {
        Type = gameObject.name;

    }

    public void SelectCard()
    {
        Destroy(gameObject);

        GameObject O = FindPiecePrefab();

        Instantiate(O);

        Cursor.SetCursor(RookSpr, Vector2.zero, CursorMode.Auto);
    }

    private GameObject FindPiecePrefab()
    {
        foreach (GameObject O in Handler.PiecePrefabs)
        {
            if (gameObject.name.Contains(O.name))
            {
                return O;
            }
        }

        return null;
    }
}
