using Sandbox.UI;
using Sandbox.UI.Construct;

namespace Sandbox.Ui.Chatbox;

public class TlouChatEntry : Panel
{
	public Label NameLabel { get; set; }
	public Label Message { get; set; }
	public Image Avatar { get; set; }
	public RealTimeSince TimeSinceBorn = 0;

	public TlouChatEntry()
	{
		Avatar = Add.Image();
		NameLabel = Add.Label( "Nom", "name" );
		Message = Add.Label( "Message", "message" );
	}

	public override void Tick()
	{
		base.Tick();
		
		if (TimeSinceBorn > 10)
			Delete();
	}
}
