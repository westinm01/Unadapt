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
                Color32 x = player.GetComponent<SpriteRenderer>().color;
                Color32 y = tm.color;
                //isMatching = tm.color.r - x.r < 0.004 && tm.color.g - x.g < 0.004 && tm.color.b - x.b < 0.004;
                //isMatching = tm.color == player.GetComponent<SpriteRenderer>().color;
                isMatching = x.r == y.r && x.g == y.g && x.b == y.b;
                Debug.Log(player.GetComponent<SpriteRenderer>().color.r + " " + tm.color.r + ", " + player.GetComponent<SpriteRenderer>().color.g + " " + tm.color.g + ", " + player.GetComponent<SpriteRenderer>().color.b + " " + tm.color.b);
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
