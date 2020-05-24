using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Oel/Oilfield")]

public class Oilfield : ScriptableObject
{
    public string oilfield_name;
    public int price;
    public int oil_amount;
    public int depth;

    public int drills_quantity;
    public int pumps_quantity;
    public int carts_quantity;

    public double oil_available;
    public double oil_used;
}
