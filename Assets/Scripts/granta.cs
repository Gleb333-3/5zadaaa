using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    private Transform _Granata;

    [SerializeField]
    private GameObject _Granataobject;

    private void Start()
    {
        _Granataobject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _Granataobject.SetActive(true);

        }
        if (_Granataobject.activeSelf)
        {
            _Granata.position = Vector3.MoveTowards(_Granata.position, transform.position, 3 * Time.deltaTime);
        }
    }
}