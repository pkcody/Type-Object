using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int currentHealth = 50;

    [SerializeField]
    public Text myText;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log(amount);

        if(myText != null)
        {
            myText.text ="Health: " + amount;
        }
    }
}
