using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HungerBar : MonoBehaviour
{
    public Image filledHungryBar;
    private DinoStats dinoStats;

    public float currentAmount;
    public float maxAmount;
    // Start is called before the first frame update
    void Start()
    {
        dinoStats = GetComponent<DinoStats>();
        maxAmount = dinoStats.maxHungerAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHungryBar(float currentAmount, float maxAmount)
    {
        filledHungryBar.fillAmount = currentAmount / maxAmount;
        Debug.Log(filledHungryBar.fillAmount);
    }
}
