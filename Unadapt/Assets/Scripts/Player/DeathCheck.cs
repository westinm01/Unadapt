using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    [SerializeField]
    private View loseMenu;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
      if(other.gameObject.tag == "Predator")
      {
        Time.timeScale = 0;
        loseMenu.Open();
      }
    }
}
