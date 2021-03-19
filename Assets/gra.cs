using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gra : MonoBehaviour
{
    [SerializeField]
    private GameObject _Sozdaiomobject;

    [SerializeField]
    private Transform _Granatmesto;

    [SerializeField]
    private GameObject _Gran;

    [SerializeField]
    private Transform _GranataTransform;

    private void Start()
    {
        _Gran.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _Gran.SetActive(true);

        }
         if (_Gran.activeSelf)
        {
         _Granatmesto.position = Vector3.MoveTowards(_Granatmesto.position, transform.position, 13 * Time.deltaTime);
  }
        int a = 1; 
        var dis = Vector3.Distance(_GranataTransform.position, _Granatmesto.position);
        if(dis < a)
        {
            Destroy(_Gran);
            Instantiate(_Sozdaiomobject, _Granatmesto.position, Quaternion.identity);
            }
        }
    }