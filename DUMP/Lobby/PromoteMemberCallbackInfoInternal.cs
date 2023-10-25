using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000463 RID: 1123
	[Token(Token = "0x2000463")]
	internal struct PromoteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<PromoteMemberCallbackInfo>, ISettable<PromoteMemberCallbackInfo>, IDisposable
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00007FAC File Offset: 0x000061AC
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000813")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D05")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D06")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000814")]
		public object ClientData
		{
			[Token(Token = "0x6001D07")]
			[Address(RVA = "0x531A50", Offset = "0x530050", VA = "0x180531A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D08")]
			[Address(RVA = "0x531B30", Offset = "0x530130", VA = "0x180531B30")]
			set
			{
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00007FC4 File Offset: 0x000061C4
		[Token(Token = "0x17000815")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000816")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x531AC0", Offset = "0x5300C0", VA = "0x180531AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x531B90", Offset = "0x530190", VA = "0x180531B90")]
			set
			{
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x531990", Offset = "0x52FF90", VA = "0x180531990", Slot = "6")]
		public void Set(ref PromoteMemberCallbackInfo other)
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x531870", Offset = "0x52FE70", VA = "0x180531870", Slot = "7")]
		public void Set(ref PromoteMemberCallbackInfo? other)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x5317F0", Offset = "0x52FDF0", VA = "0x1805317F0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x531850", Offset = "0x52FE50", VA = "0x180531850", Slot = "5")]
		public void Get(out PromoteMemberCallbackInfo output)
		{
		}

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
