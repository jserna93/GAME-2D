using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int score;
    public int scoringAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coins")
        {
            score+= scoringAmount;
            Destroy(collision.gameObject);
            Debug.Log(score);

        }
    }
}
