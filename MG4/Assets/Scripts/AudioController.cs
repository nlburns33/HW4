using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource _source1;
    [SerializeField] AudioSource _source2;
    [SerializeField] AudioSource _source3;

    void Start()
    {
        Locator.Instance.Player.PointsChanged += EarnedPoint;
        Locator.Instance.Player.Ender += Lost;
        Locator.Instance.Player.Jump += Jumped;
    }

    void EarnedPoint(int points)
    {
       
        _source1.Play();
    }
    void Lost()
    {
        
        _source2.Play();
    }
    void Jumped()
    {
       
        _source3.Play();
    }
}
