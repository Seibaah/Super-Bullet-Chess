using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public List<GameObject> PiecePrefabs;
    public List<Texture2D> PieceSprites;

    void Start()
    {
        //framerate limiter
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
