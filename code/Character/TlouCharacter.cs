using Sandbox.Character.Inventory;

namespace Sandbox.Character;

public class TlouCharacter : Player
{
	// PROPRIETES
	//
	public string Description { get; private set; }


	// INITIALIZE & CONSTRUCT
	//
	public TlouCharacter()
	{
		
	}

	public TlouCharacter( string name, string description )
	{
		Name = name;
		Description = description;
		Inventory = new TlouInventory(this);
	}
	
	
	public override void Spawn()
	{
		base.Spawn();
		
		CameraMode = new FirstPersonCamera();
		Controller = new WalkController();
		Animator = new StandardPlayerAnimator();
		Model = Model.Load( "models/citizen/citizen.vmdl" );
		EnableDrawing = true;
		EnableAllCollisions = true;
		UsePhysicsCollision = true;
		MoveType = MoveType.Physics;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;

		CollisionGroup = CollisionGroup.Player;
	}
}
