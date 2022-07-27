using Sandbox.Character;
using SandboxEditor;

namespace Sandbox.Items;

public class TlouItem : BaseCarriable
{
	// PROPRIETES
	//
	public string Name { get; set; }
	public Model Model { get; set; }

	public TlouItem()
	{
		Model = Model.Load( "models/weapons/shortsword/shortsword.vmdl" );
	}
}
