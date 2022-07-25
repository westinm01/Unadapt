using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpColor : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sprite;
    public float duration = 3.0f;
    private float timer = 0f;
    public int startState=0;
    private int state=0;

    public Color color0 = Color.red;
    public Color color1 = Color.blue;
    public Color color2 = Color.green;
    
    void Start(){
        state=startState;
    }
    // Update is called once per frame
    void Update()
    {
        
        float t = Mathf.PingPong(Time.time, duration) / duration;
        timer+=Time.deltaTime;
        if(timer>=duration){
            state=(state+1)%6;
            timer=0;
        }
        switch(state){
            case 0:
                sprite.color = Color.Lerp(color0, color1, t);
            break;
            case 1:
                sprite.color = Color.Lerp(color2, color1, t);
            break;
            case 2:
                sprite.color = Color.Lerp(color2, color0, t);
            break;
            case 3:
                sprite.color = Color.Lerp(color1, color0, t);
            break;
            case 4:
                sprite.color = Color.Lerp(color1, color2, t);
            break;
            case 5:
                sprite.color = Color.Lerp(color0, color2, t);
                break;
        }
        
    }
}
