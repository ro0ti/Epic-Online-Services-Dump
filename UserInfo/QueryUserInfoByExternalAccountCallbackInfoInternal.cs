using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	internal struct QueryUserInfoByExternalAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByExternalAccountCallbackInfo>, ISettable<QueryUserInfoByExternalAccountCallbackInfo>, IDisposable
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000066")]
		public Result ResultCode
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000067")]
		public object ClientData
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x4AE2D0", Offset = "0x4AC8D0", VA = "0x1804AE2D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x4AE4E0", Offset = "0x4ACAE0", VA = "0x1804AE4E0")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x17000068")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000069")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x4AE3E0", Offset = "0x4AC9E0", VA = "0x1804AE3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x4AE5E0", Offset = "0x4ACBE0", VA = "0x1804AE5E0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006A")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x4AE370", Offset = "0x4AC970", VA = "0x1804AE370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x4AE580", Offset = "0x4ACB80", VA = "0x1804AE580")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006B")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006C")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x4AE460", Offset = "0x4ACA60", VA = "0x1804AE460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x4AE690", Offset = "0x4ACC90", VA = "0x1804AE690")]
			set
			{
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x4AE0D0", Offset = "0x4AC6D0", VA = "0x1804AE0D0", Slot = "6")]
		public void Set(ref QueryUserInfoByExternalAccountCallbackInfo other)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x4AE180", Offset = "0x4AC780", VA = "0x1804AE180", Slot = "7")]
		public void Set(ref QueryUserInfoByExternalAccountCallbackInfo? other)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x4ADF40", Offset = "0x4AC540", VA = "0x1804ADF40", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x4AE0B0", Offset = "0x4AC6B0", VA = "0x1804AE0B0", Slot = "5")]
		public void Get(out QueryUserInfoByExternalAccountCallbackInfo output)
		{
		}

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ExternalAccountId;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x20")]
		private ExternalAccountType m_AccountType;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_TargetUserId;
	}
}
