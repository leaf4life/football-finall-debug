using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScore;
    private StarterAssetsInputs starterAssetsInputs;
    private int myScore, otherScore;

    public int OtherScore { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (starterAssetsInputs.shoot)
        {
            Debug.Log("Shoot!");
        }
    }
    public void IncreaseMyScore()
    {
        myScore++;
        UpdateScore();
        
    }

    public void IncreaseOtherScore()
    {
        OtherScore++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        textScore.text = "Score: " + myScore.ToString() + "-" + otherScore.ToString();
    }

}
