using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200044E RID: 1102
	// (Invoke) Token: 0x06001CB0 RID: 7344
	[Token(Token = "0x200044E")]
	public delegate void OnLobbyMemberUpdateReceivedCallback(ref LobbyMemberUpdateReceivedCallbackInfo data);
}
