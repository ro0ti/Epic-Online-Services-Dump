using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	internal struct ReceiveMessageFromPeerOptionsInternal : ISettable<ReceiveMessageFromPeerOptions>, IDisposable
	{
		// Token: 0x17000DAE RID: 3502
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAE")]
		public IntPtr PeerHandle
		{
			[Token(Token = "0x6002E26")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAF")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E27")]
			[Address(RVA = "0x57DA60", Offset = "0x57C060", VA = "0x18057DA60")]
			set
			{
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x57D9E0", Offset = "0x57BFE0", VA = "0x18057D9E0", Slot = "4")]
		public void Set(ref ReceiveMessageFromPeerOptions other)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x57D900", Offset = "0x57BF00", VA = "0x18057D900", Slot = "5")]
		public void Set(ref ReceiveMessageFromPeerOptions? other)
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x57D8A0", Offset = "0x57BEA0", VA = "0x18057D8A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PeerHandle;

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x10")]
		private uint m_DataLengthBytes;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Data;
	}
}
