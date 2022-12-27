using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public List<GameObject> _shopItems = new List<GameObject>();
    public ManagerScript _manager;

    void Start()
    {
        foreach (Transform child in transform)
        {
            _shopItems.Add(child.gameObject);
        }
    }


    void Update()
    {
        
    }


}
