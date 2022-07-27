using System;
using System.Linq;
using Sandbox.Character;

namespace Sandbox;

public partial class TlouGame : Game
{
	public TlouGame()
	{
		
	}
	

	// TRACE SYSTEM
	private static Entity TraceSystem(TlouCharacter caller)
	{
		var trace = Trace.Ray( caller.EyePosition, caller.EyePosition + caller.EyeRotation.Forward * 300 )
			.Ignore( caller )
			.UseHitboxes()
			.Size( 2 )
			.WorldAndEntities()
			.Run();

		return trace.Entity;
	}
	

	// WHEN A CLIEN JOINED
	//
	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );

		// CHARACTER CREATION
		//
		var character = new TlouCharacter("Joël Miller", "Père adoptif d'Ellie");
		client.Pawn = character;
		
		// SPAWNPOINTS
		var spawnpoints = Entity.All.OfType<SpawnPoint>();
		var randomSpawnPoint = spawnpoints.MinBy(x => Guid.NewGuid());
		if ( randomSpawnPoint != null )
		{
			var tx = randomSpawnPoint.Transform;
			tx.Position = tx.Position + Vector3.Up * 50.0f; // raise it up
			character.Transform = tx;
		}
	}
}
