using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x02000698 RID: 1688
	[Token(Token = "0x2000698")]
	internal struct AddNotifyMessageToClientOptionsInternal : ISettable<AddNotifyMessageToClientOptions>, IDisposable
	{
		// Token: 0x06002B62 RID: 11106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyMessageToClientOptions other)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x56B390", Offset = "0x569990", VA = "0x18056B390", Slot = "5")]
		public void Set(ref AddNotifyMessageToClientOptions? other)
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012D2 RID: 4818
		[Token(Token = "0x40012D2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
