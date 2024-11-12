using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int currHealth;
    public int currHealthMax;
    public int damageAmount;

    public static Health instance;
    public Healthbar healthBar;

    private void Awake()
    {
        instance = this;

    }


    // Start is called before the first frame update
    void Start()
    {

        currHealth = currHealthMax;
        healthBar.SetMaxHealth(currHealth);





    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DealDamage()
    {
        currHealth -= damageAmount;
        healthBar.SetHealth(currHealth);

        if (currHealth < 0)
        {
            gameObject.SetActive(false);


        }

    }
}
