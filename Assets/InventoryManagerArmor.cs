using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManagerArmor : MonoBehaviour
{
 public static InventoryManagerArmor instance;
    public ScriptableItem[] shield;
    public Text[] shieldNames;
    public Text[] shieldPrices;
    public Image[] shieldSprites;


    void Awake()
    {
       if(instance != null && instance != this)
       {
        Destroy(gameObject);
        }
        else
        {
         instance = this;
         }

       } 
   
   public void AddItem(ScriptableItem item)
   {
        for (int i = 0; i < shield.Length; i++)
        {
            if(shield[i] == null)
            {
                shield[i] = item;
                shieldNames[i].text = item.WeaponName;
                shieldSprites[i].sprite = item.WeaponSprite;
                shieldPrices[i].text = item.WeaponPrice;

         

                return;
            }
        }
   }
   
}
