using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;

    // Reminder: "protected" = "private" but visible to children
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;

            // +5 pesos
            GameManager.instance.ShowText("+" + pesosAmount + " pesos!",15,Color.yellow,transform.position,Vector3.up * 50, 1.5f);
            // Debug.Log("Grant " + pesosAmount + " pesos!");
        }
    }
}
