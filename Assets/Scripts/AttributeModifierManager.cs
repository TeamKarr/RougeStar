using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeModifierManager : MonoBehaviour
{
    // Start is called before the first frame update

    public AttributeManager target;

    public List<ModifierHandler> modifiers = new ();

    public bool onCollision = true;

    private bool active = false;

    private Collision2D collision2D;

    void Start()
    {
        collision2D = GetComponent<Collision2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        //if (onCollision) { 
        //    collision2D.get
        //}
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!active && onCollision)
        {
            if (target.Equals(collision.gameObject.GetComponent<AttributeManager>()))
            {
                Debug.Log("Object entered trigger: " + collision.gameObject.name);
            }
        }
       
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (active) {
            if (target.Equals(collision.gameObject.GetComponent<AttributeManager>()))
            {
                Debug.Log("Object exited trigger: " + collision.gameObject.name);
            }
        }
        
    }

    [System.Serializable]
    public class ModifierHandler
    {
        public Attribute attribute;
        public Attribute.AttributeModifier modifiers;
    }
}
