using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	internal struct ShowFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<ShowFriendsCallbackInfo>, ISettable<ShowFriendsCallbackInfo>, IDisposable
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00002D74 File Offset: 0x00000F74
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EC")]
		public Result ResultCode
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000ED")]
		public object ClientData
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x4B0220", Offset = "0x4AE820", VA = "0x1804B0220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x4B0340", Offset = "0x4AE940", VA = "0x1804B0340")]
			set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x170000EE")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EF")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x4B02C0", Offset = "0x4AE8C0", VA = "0x1804B02C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x4B03E0", Offset = "0x4AE9E0", VA = "0x1804B03E0")]
			set
			{
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x4B0130", Offset = "0x4AE730", VA = "0x1804B0130", Slot = "6")]
		public void Set(ref ShowFriendsCallbackInfo other)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x4B0170", Offset = "0x4AE770", VA = "0x1804B0170", Slot = "7")]
		public void Set(ref ShowFriendsCallbackInfo? other)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x4AFFF0", Offset = "0x4AE5F0", VA = "0x1804AFFF0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4B00D0", Offset = "0x4AE6D0", VA = "0x1804B00D0", Slot = "5")]
		public void Get(out ShowFriendsCallbackInfo output)
		{
		}

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
