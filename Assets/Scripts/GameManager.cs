using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    public float timer;

    public float timeLimit;

    public TMP_Text timerText;

    [Header("Collectables")]
    public int requiredCollectables;
    public int currentCollectables;
    public TMP_Text collectablesText;

    [Header("Deliveries")]
    public TextMeshProUGUI deliveryText;
    public static int foodDelivered;
    public int amountOfDeliveries = 2;
    public int displayAmount; 

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
        foodDelivered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
        Collectables();

        displayAmount = amountOfDeliveries - foodDelivered;
        deliveryText.text = displayAmount.ToString() + "/"+amountOfDeliveries                                   ;

    if (foodDelivered == amountOfDeliveries)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    if (Input.GetKeyDown(KeyCode.R))
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void GameTimer()
    {
        timerText.text = timer.ToString("F2");

        if (timer <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Collectables()
    {
        collectablesText.text = currentCollectables + " / " + requiredCollectables;

        
       

    }
}
