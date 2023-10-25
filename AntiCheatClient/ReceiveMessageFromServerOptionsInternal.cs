using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	internal struct ReceiveMessageFromServerOptionsInternal : ISettable<ReceiveMessageFromServerOptions>, IDisposable
	{
		// Token: 0x17000DB1 RID: 3505
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB1")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E2D")]
			[Address(RVA = "0x57DC70", Offset = "0x57C270", VA = "0x18057DC70")]
			set
			{
			}
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x57DB30", Offset = "0x57C130", VA = "0x18057DB30", Slot = "4")]
		public void Set(ref ReceiveMessageFromServerOptions other)
		{
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x57DBB0", Offset = "0x57C1B0", VA = "0x18057DBB0", Slot = "5")]
		public void Set(ref ReceiveMessageFromServerOptions? other)
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x57DAE0", Offset = "0x57C0E0", VA = "0x18057DAE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DataLengthBytes;

		// Token: 0x0400148C RID: 5260
		[Token(Token = "0x400148C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Data;
	}
}
