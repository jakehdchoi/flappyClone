using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// hi
public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Best Score: " + Score.bestScore;
    }

}
