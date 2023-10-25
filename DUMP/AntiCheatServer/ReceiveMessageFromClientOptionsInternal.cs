using System;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A9 RID: 1705
	[Token(Token = "0x20006A9")]
	internal struct ReceiveMessageFromClientOptionsInternal : ISettable<ReceiveMessageFromClientOptions>, IDisposable
	{
		// Token: 0x17000CC8 RID: 3272
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC8")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BC6")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC9")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BC7")]
			[Address(RVA = "0x57D820", Offset = "0x57BE20", VA = "0x18057D820")]
			set
			{
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x57D6C0", Offset = "0x57BCC0", VA = "0x18057D6C0", Slot = "4")]
		public void Set(ref ReceiveMessageFromClientOptions other)
		{
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x57D740", Offset = "0x57BD40", VA = "0x18057D740", Slot = "5")]
		public void Set(ref ReceiveMessageFromClientOptions? other)
		{
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x57D660", Offset = "0x57BC60", VA = "0x18057D660", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012F9 RID: 4857
		[Token(Token = "0x40012F9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x040012FA RID: 4858
		[Token(Token = "0x40012FA")]
		[FieldOffset(Offset = "0x10")]
		private uint m_DataLengthBytes;

		// Token: 0x040012FB RID: 4859
		[Token(Token = "0x40012FB")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Data;
	}
}
