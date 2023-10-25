using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	internal struct SessionDetailsInfoInternal : IGettable<SessionDetailsInfo>, ISettable<SessionDetailsInfo>, IDisposable
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000244")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x4C7B60", Offset = "0x4C6160", VA = "0x1804C7B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x4C7D70", Offset = "0x4C6370", VA = "0x1804C7D70")]
			set
			{
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000245")]
		public Utf8String HostAddress
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x4C7A00", Offset = "0x4C6000", VA = "0x1804C7A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x4C7C50", Offset = "0x4C6250", VA = "0x1804C7C50")]
			set
			{
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00003D34 File Offset: 0x00001F34
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000246")]
		public uint NumOpenPublicConnections
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00003D4C File Offset: 0x00001F4C
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000247")]
		public SessionDetailsSettings? Settings
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x4C7BD0", Offset = "0x4C61D0", VA = "0x1804C7BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x4C7DD0", Offset = "0x4C63D0", VA = "0x1804C7DD0")]
			set
			{
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000248")]
		public ProductUserId OwnerUserId
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x4C7AE0", Offset = "0x4C60E0", VA = "0x1804C7AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x4C7D10", Offset = "0x4C6310", VA = "0x1804C7D10")]
			set
			{
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000249")]
		public Utf8String OwnerServerClientId
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x4C7A70", Offset = "0x4C6070", VA = "0x1804C7A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x4C7CB0", Offset = "0x4C62B0", VA = "0x1804C7CB0")]
			set
			{
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x4C75D0", Offset = "0x4C5BD0", VA = "0x1804C75D0", Slot = "5")]
		public void Set(ref SessionDetailsInfo other)
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x4C7790", Offset = "0x4C5D90", VA = "0x1804C7790", Slot = "6")]
		public void Set(ref SessionDetailsInfo? other)
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x4C7520", Offset = "0x4C5B20", VA = "0x1804C7520", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x4C75A0", Offset = "0x4C5BA0", VA = "0x1804C75A0", Slot = "4")]
		public void Get(out SessionDetailsInfo output)
		{
		}

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionId;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_HostAddress;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x18")]
		private uint m_NumOpenPublicConnections;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Settings;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_OwnerUserId;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_OwnerServerClientId;
	}
}
