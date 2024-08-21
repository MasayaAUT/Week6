using UnityEngine;

[CreateAssetMenu(menuName = "Weapon", fileName = "New Weapon")]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public Sprite weaponImage;
    public string weaponDescription;
    public int cost;
    public int damage;
    public int magicDamage;
}
