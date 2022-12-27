using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemScript : MonoBehaviour
{
    public bool _iminShop;
    public Inventory _inventory;
    public ShopScript _shopScript;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        if(_shopScript._shopItems.Contains(gameObject))
        {
            _inventory._itemS.Add(gameObject);
            gameObject.transform.parent = _inventory.transform;
            _shopScript._shopItems.Remove(gameObject);
        }
        else if (_inventory._itemS.Contains(gameObject))
        {
            _shopScript._shopItems.Add(gameObject);
            gameObject.transform.parent = _shopScript.transform;
            print("acá llego!");
        }



        print(gameObject);
    }
}
