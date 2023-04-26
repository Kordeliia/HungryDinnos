using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedSystemController : MonoBehaviour
{
    public DinoStats dinoStats;
    public FoodStats foodStats;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedDino(GameObject food, GameObject dino)
    {
        dinoStats = dino.GetComponent<DinoStats>();
        foodStats = dino.GetComponent<FoodStats>();
        dinoStats.hungerAmount += foodStats.fillAmount;
    }
}
