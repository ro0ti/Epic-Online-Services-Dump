using System;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	internal struct QueryUserInfoCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoCallbackInfo>, ISettable<QueryUserInfoCallbackInfo>, IDisposable
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000077")]
		public Result ResultCode
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000078")]
		public object ClientData
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x4AEEC0", Offset = "0x4AD4C0", VA = "0x1804AEEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x4AF060", Offset = "0x4AD660", VA = "0x1804AF060")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x17000079")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x4AEF60", Offset = "0x4AD560", VA = "0x1804AEF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x4AF100", Offset = "0x4AD700", VA = "0x1804AF100")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007B")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x4AEFE0", Offset = "0x4AD5E0", VA = "0x1804AEFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x4AF1B0", Offset = "0x4AD7B0", VA = "0x1804AF1B0")]
			set
			{
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x4AEE70", Offset = "0x4AD470", VA = "0x1804AEE70", Slot = "6")]
		public void Set(ref QueryUserInfoCallbackInfo other)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x4AED90", Offset = "0x4AD390", VA = "0x1804AED90", Slot = "7")]
		public void Set(ref QueryUserInfoCallbackInfo? other)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x4AEBF0", Offset = "0x4AD1F0", VA = "0x1804AEBF0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x4AED10", Offset = "0x4AD310", VA = "0x1804AED10", Slot = "5")]
		public void Get(out QueryUserInfoCallbackInfo output)
		{
		}

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
