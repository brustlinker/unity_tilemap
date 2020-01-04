using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class 测试 : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase tilebase;

    // Start is called before the first frame update
    void Start()
    {
        //清空所有的格子
        //tilemap.ClearAllTiles();
        TileBase tile = tilemap.GetTile(new Vector3Int(-2, -2, 0));
        Debug.Log(tile);


        tilemap.SetTile(Vector3Int.zero,tilebase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
