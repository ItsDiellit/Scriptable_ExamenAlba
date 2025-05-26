using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]

public class ScriptableItem : ScriptableObject
{
public string WeaponName;
public string WeaponPrice;
public Sprite WeaponSprite;
}
