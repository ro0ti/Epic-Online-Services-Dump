using System;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A7 RID: 1703
	[Token(Token = "0x20006A7")]
	internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable
	{
		// Token: 0x17000CC3 RID: 3267
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC3")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BBC")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC4")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BBD")]
			[Address(RVA = "0x57C810", Offset = "0x57AE10", VA = "0x18057C810")]
			set
			{
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC5")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002BBE")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BBF")]
		[Address(RVA = "0x57C560", Offset = "0x57AB60", VA = "0x18057C560", Slot = "4")]
		public void Set(ref ProtectMessageOptions other)
		{
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0x57C450", Offset = "0x57AA50", VA = "0x18057C450", Slot = "5")]
		public void Set(ref ProtectMessageOptions? other)
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x57C3A0", Offset = "0x57A9A0", VA = "0x18057C3A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x10")]
		private uint m_DataLengthBytes;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Data;

		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x40012F5")]
		[FieldOffset(Offset = "0x20")]
		private uint m_OutBufferSizeBytes;
	}
}
