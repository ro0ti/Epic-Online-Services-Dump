using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	internal struct AddNotifyLeaveLobbyRequestedOptionsInternal : ISettable<AddNotifyLeaveLobbyRequestedOptions>, IDisposable
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLeaveLobbyRequestedOptions other)
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x505200", Offset = "0x503800", VA = "0x180505200", Slot = "5")]
		public void Set(ref AddNotifyLeaveLobbyRequestedOptions? other)
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
