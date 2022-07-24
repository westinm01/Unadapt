using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicIterator : MonoBehaviour
{
    // Start is called before the first frame update
    public List <GameObject> comicPanels;
    public int index = 0;
    public int nextSceneIndex = 0;

    [SerializeField]
    private SceneController sc;

    void Start()
    {
        
    }

    public void ShowNextPanel()
    {
        
        if(index < comicPanels.Count)
        {
            
            if(index > 0)
            {
                comicPanels[index - 1].SetActive(false);
            }
            comicPanels[index++].SetActive(true);
            
        }
        else{
            //Reached end of comic, load new scene
            
            sc.LoadScene(nextSceneIndex);
        }
        
    }
}
