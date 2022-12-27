using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{


    public GameObject _container;
    public List<GameObject> _itemS = new List<GameObject>();

    void Start()
    {
        _container = GameObject.Find("ItemContainer");
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var item = Instantiate(Resources.Load("Item") as GameObject, transform.position, Quaternion.identity);
            item.transform.parent = _container.transform;
            _itemS.Add(item);
        }
    }
}
