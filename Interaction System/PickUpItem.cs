using System.Collections;
using UnityEngine;

public class PickUpItem : Interactable
{
	[Header("Item Data")]	
	[SerializeField] string itemName;
    [SerializeField] int amount = 1;

    public override void Start()
	{
		base.Start();
        interactableName = itemName;		
    }

    protected override void Interaction()
	{
		base.Interaction();
        print("I put " + itemName + " in my inventory.");
        
        //animation
        animator.SetTrigger("PickUp");

        //add to inventory via events
        Events.AddInventoryItem(this, amount);
        
        Destroy(this.gameObject);
	}

}
