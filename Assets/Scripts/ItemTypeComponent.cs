using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTypeComponent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    protected ItemType _itemType;
    public ItemType Type{
        get {
            return _itemType;
        }
        set{
            _itemType = value;
        }
    }
}
