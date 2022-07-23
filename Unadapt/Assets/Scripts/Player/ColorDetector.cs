using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ColorDetector : MonoBehaviour
{
    // Start is called before the first frame update

    //private Tilemap tm;
    public Grid grid;
    public GameObject player;
    public bool isMatching = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3Int lPos = grid.WorldToCell(player.transform.position);
        foreach (Transform child in grid.gameObject.transform)
        {
            Tilemap tm = child.gameObject.GetComponent<Tilemap>();
            if(tm.GetTile(lPos) != null)
            {
                isMatching = tm.color == player.GetComponent<SpriteRenderer>().color;
            }
        }
    }
/*
    void OnTriggerEnter2D(Collision2D col)
    {
        if(col.SpriteRenderer.color == tm.color)
        {
            isMatching = true;
        }
        else{
            isMatching = false;
        }
    }*/
    
}
