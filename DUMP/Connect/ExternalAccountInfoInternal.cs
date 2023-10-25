using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	internal struct ExternalAccountInfoInternal : IGettable<ExternalAccountInfo>, ISettable<ExternalAccountInfo>, IDisposable
	{
		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7F")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002798")]
			[Address(RVA = "0x55A6B0", Offset = "0x558CB0", VA = "0x18055A6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002799")]
			[Address(RVA = "0x55A860", Offset = "0x558E60", VA = "0x18055A860")]
			set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B80")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600279A")]
			[Address(RVA = "0x55A5D0", Offset = "0x558BD0", VA = "0x18055A5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600279B")]
			[Address(RVA = "0x55A790", Offset = "0x558D90", VA = "0x18055A790")]
			set
			{
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B81")]
		public Utf8String AccountId
		{
			[Token(Token = "0x600279C")]
			[Address(RVA = "0x55A560", Offset = "0x558B60", VA = "0x18055A560")]
			get
			{
				return null;
			}
			[Token(Token = "0x600279D")]
			[Address(RVA = "0x55A730", Offset = "0x558D30", VA = "0x18055A730")]
			set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0000A13C File Offset: 0x0000833C
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B82")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600279E")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x600279F")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x0000A154 File Offset: 0x00008354
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B83")]
		public DateTimeOffset? LastLoginTime
		{
			[Token(Token = "0x60027A0")]
			[Address(RVA = "0x55A640", Offset = "0x558C40", VA = "0x18055A640")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027A1")]
			[Address(RVA = "0x55A7F0", Offset = "0x558DF0", VA = "0x18055A7F0")]
			set
			{
			}
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x55A3E0", Offset = "0x5589E0", VA = "0x18055A3E0", Slot = "5")]
		public void Set(ref ExternalAccountInfo other)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x55A1E0", Offset = "0x5587E0", VA = "0x18055A1E0", Slot = "6")]
		public void Set(ref ExternalAccountInfo? other)
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x55A140", Offset = "0x558740", VA = "0x18055A140", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x55A1B0", Offset = "0x5587B0", VA = "0x18055A1B0", Slot = "4")]
		public void Get(out ExternalAccountInfo output)
		{
		}

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ProductUserId;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DisplayName;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x20")]
		private ExternalAccountType m_AccountIdType;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x28")]
		private long m_LastLoginTime;
	}
}
