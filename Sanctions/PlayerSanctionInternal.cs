using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	internal struct PlayerSanctionInternal : IGettable<PlayerSanction>, ISettable<PlayerSanction>, IDisposable
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000044CC File Offset: 0x000026CC
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CB")]
		public long TimePlaced
		{
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CC")]
		public Utf8String Action
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x4DEAA0", Offset = "0x4DD0A0", VA = "0x1804DEAA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x4DEB80", Offset = "0x4DD180", VA = "0x1804DEB80")]
			set
			{
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x000044E4 File Offset: 0x000026E4
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CD")]
		public long TimeExpires
		{
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CE")]
		public Utf8String ReferenceId
		{
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x4DEB10", Offset = "0x4DD110", VA = "0x1804DEB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x4DEBE0", Offset = "0x4DD1E0", VA = "0x1804DEBE0")]
			set
			{
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x4DE880", Offset = "0x4DCE80", VA = "0x1804DE880", Slot = "5")]
		public void Set(ref PlayerSanction other)
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x4DE950", Offset = "0x4DCF50", VA = "0x1804DE950", Slot = "6")]
		public void Set(ref PlayerSanction? other)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x4DE800", Offset = "0x4DCE00", VA = "0x1804DE800", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x4DE860", Offset = "0x4DCE60", VA = "0x1804DE860", Slot = "4")]
		public void Get(out PlayerSanction output)
		{
		}

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x8")]
		private long m_TimePlaced;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Action;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x18")]
		private long m_TimeExpires;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ReferenceId;
	}
}
