using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameCursorMode
{
    Select,
    Spawn,
    Move
}

public class Player : MonoBehaviour
{
    GameCursorMode Mode;

    void Start()
    {
        
    }

    void Update()
    {
        if (Mode == GameCursorMode.Spawn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SetGameCursorMode(null, GameCursorMode.Select);
            }
        }
    }

    public void SetGameCursorMode(Texture2D T, GameCursorMode M)
    {
        Mode = M;
        Cursor.SetCursor(T, Vector2.zero, CursorMode.Auto);
    }
}
