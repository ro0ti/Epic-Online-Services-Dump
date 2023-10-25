using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public enum RTCAudioInputStatus
	{
		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		Idle,
		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		Recording,
		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		RecordingSilent,
		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		RecordingDisconnected,
		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		Failed
	}
}
