using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance {  get; private set; }
    public Player Player { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        GameObject playerObject = GameObject.FindWithTag("Player");
        Player = playerObject.GetComponent<Player>();
    }


}
