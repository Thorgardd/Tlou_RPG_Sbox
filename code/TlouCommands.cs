using System;
using Sandbox.Character;
using Sandbox.Character.Inventory;
using Sandbox.Items;

namespace Sandbox;

public partial class TlouGame
{
	// Infos for yourself
	//
	[ConCmd.Server( "/Infos" )]
	public static void GetInfos()
	{
		var caller = ConsoleSystem.Caller.Pawn as TlouCharacter;
		if ( caller == null )
			return;
		Log.Info( $"Nom : {caller.Name}" );
		Log.Info( $"Description : {caller.Description}" );
	}

	// Infos for the target player by looking at him
	//
	[ConCmd.Server( "/InfosTrace" )]
	public static void GetCharTraceInfos()
	{
		var caller = ConsoleSystem.Caller.Pawn as TlouCharacter;
		
		var receiver = (TraceSystem(caller) as TlouCharacter);

		if ( receiver == null && receiver is not TlouCharacter)
		{
			Log.Info( "ERREUR" );
			return;
		}

		Log.Info( $"Nom : {receiver.Name}" );
		Log.Info( $"Description : {receiver.Description}" );
	}
	
	// Show if Inventory exists
	//
	[ConCmd.Client( "/Inventory" )]
	public static void GetInventory()
	{
		var caller = ConsoleSystem.Caller.Pawn as TlouCharacter;
		
		if ( caller?.Inventory == null && caller.Inventory is not TlouInventory )
			Log.Info( "Il n'y a pas d'inventaire disponible pour le personnage actuel" );
		
		Log.Info( "Inventaire disponible pour le personnage actuel" );
	}
}
