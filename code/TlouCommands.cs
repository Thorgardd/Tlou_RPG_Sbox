using Sandbox.Character;

namespace Sandbox;

public partial class TlouGame
{
	[ConCmd.Server( "/Infos" )]
	public static void GetInfos()
	{
		var caller = ConsoleSystem.Caller.Pawn as TlouCharacter;
		if ( caller == null )
			return;
		Log.Info( $"Nom : {caller.Name}" );
		Log.Info( $"Description : {caller.Description}" );
	}

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
}
