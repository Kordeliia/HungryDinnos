using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedSystemController : MonoBehaviour
{
    private DinoStats dinoStats;
    private FoodStats foodStats;
    private HungerBar hungerBar;
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
        foodStats = food.GetComponent<FoodStats>();
        hungerBar = dino.GetComponent <HungerBar>();
        dinoStats.hungerAmount += foodStats.fillAmount;
        hungerBar.UpdateHungryBar(dinoStats.hungerAmount, dinoStats.maxHungerAmount);
    }
}
