using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public ColorDetector colorDetector;
    public bool canAttack;
    void Start()
    {
        canAttack = false;
    }

    // Update is called once per frame
    void Update()
    {
        canAttack = !colorDetector.isMatching;
    }
}
