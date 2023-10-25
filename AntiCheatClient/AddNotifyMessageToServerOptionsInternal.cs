using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006F3 RID: 1779
	[Token(Token = "0x20006F3")]
	internal struct AddNotifyMessageToServerOptionsInternal : ISettable<AddNotifyMessageToServerOptions>, IDisposable
	{
		// Token: 0x06002D92 RID: 11666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyMessageToServerOptions other)
		{
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x56B430", Offset = "0x569A30", VA = "0x18056B430", Slot = "5")]
		public void Set(ref AddNotifyMessageToServerOptions? other)
		{
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
