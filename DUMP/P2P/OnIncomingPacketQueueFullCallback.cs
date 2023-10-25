using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200033A RID: 826
	// (Invoke) Token: 0x060015FD RID: 5629
	[Token(Token = "0x200033A")]
	public delegate void OnIncomingPacketQueueFullCallback(ref OnIncomingPacketQueueFullInfo data);
}
