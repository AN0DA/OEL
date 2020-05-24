using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Oel/Factory")]

public class Factory : ScriptableObject {
    public int factory_type;
    public string factory_name;
    public int factory_price;

    public int factory_item_quantity;
    public int factory_item_price;

    public int factory_owner;
}
