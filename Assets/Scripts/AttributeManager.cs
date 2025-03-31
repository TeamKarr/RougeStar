using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Attribute> attributes = new();

    public Attribute getAttribute(string name)
    {
        foreach (Attribute a in attributes)
        {
            if (a.name == name)
            {
                return a;
            }
        }
        return null;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}

[System.Serializable]
public class Attribute
{

    public string name;
    public string description;
    public float baseValue;

    public List<AttributeModifier> modifiers = new();

    public Attribute()
    {

    }

    [System.Serializable]
    public class AttributeModifier
    {
        public ModifierType type;
        public float value;
        public bool enabled = true;
        public string tag;


    }

    public enum ModifierType { add, multiply, multiplyBase }
}