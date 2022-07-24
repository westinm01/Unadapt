using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorMovement : MonoBehaviour
{
    private PredatorDetect detector;
    public bool freezeAtEnd = false;// if  you want something to freeze at the end.
    public List<Transform> positions;
    public int positionsIndex=0;
    public float speed;
    public float attackSpeed = 10f;
    private float oldSpeed;
    public Transform startPos;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<PredatorDetect>();
        nextPos = startPos.position;
        oldSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(detector.canAttack){
            nextPos = detector.colorDetector.player.transform.position;
            nextPos.z = -2; // so that the bird is on top of the player at all times.
            speed = attackSpeed;
        }
        else{
            speed = oldSpeed;
            if(transform.position == positions[positionsIndex].position)
            {
                
                if(positionsIndex < positions.Count - 1)
                {
                    //Debug.Log("index increased to " + positionsIndex);
                    positionsIndex++;
                }
                else{
                    //Debug.Log("Hit else");
                    if (!freezeAtEnd){
                        positionsIndex = 0;//Goes back to start
                    }
                }
                
            }
            nextPos = positions[positionsIndex].position;
            
        }
        
        GetComponent<SpriteRenderer>().flipX = nextPos.x > transform.position.x;
        
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
