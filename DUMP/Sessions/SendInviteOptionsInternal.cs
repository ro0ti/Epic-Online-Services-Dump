using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable
	{
		// Token: 0x17000226 RID: 550
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000226")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x4C62D0", Offset = "0x4C48D0", VA = "0x1804C62D0")]
			set
			{
			}
		}

		// Token: 0x17000227 RID: 551
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000227")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x4C6270", Offset = "0x4C4870", VA = "0x1804C6270")]
			set
			{
			}
		}

		// Token: 0x17000228 RID: 552
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000228")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x4C6330", Offset = "0x4C4930", VA = "0x1804C6330")]
			set
			{
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x4C6170", Offset = "0x4C4770", VA = "0x1804C6170", Slot = "4")]
		public void Set(ref SendInviteOptions other)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x4C6010", Offset = "0x4C4610", VA = "0x1804C6010", Slot = "5")]
		public void Set(ref SendInviteOptions? other)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x4C5FA0", Offset = "0x4C45A0", VA = "0x1804C5FA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
