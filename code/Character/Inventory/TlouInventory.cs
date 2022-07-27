using System.Collections.Generic;

namespace Sandbox.Character.Inventory;

public partial class TlouInventory : BaseInventory
{
	// PROPRIETES
	//
	public int MaxSlots { get; private set; }
	public bool ActiveSlot { get; protected set; }
	public List<Entity> List = new List<Entity>();

	public TlouInventory(Entity owner) : base(owner)
	{
		MaxSlots = 20;
	}

	public void InventaireCreation()
	{
		// TODO - IMPLEMENT FUNCTION FOR CREATING CELLS BY CODE
	}
}
