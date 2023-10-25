using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200076C RID: 1900
	[Token(Token = "0x200076C")]
	internal struct OnQueryPlayerAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, ISettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0000C92C File Offset: 0x0000AB2C
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA8")]
		public Result ResultCode
		{
			[Token(Token = "0x60030C9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030CA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA9")]
		public object ClientData
		{
			[Token(Token = "0x60030CB")]
			[Address(RVA = "0x589F20", Offset = "0x588520", VA = "0x180589F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030CC")]
			[Address(RVA = "0x58A010", Offset = "0x588610", VA = "0x18058A010")]
			set
			{
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x0000C944 File Offset: 0x0000AB44
		[Token(Token = "0x17000EAA")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60030CD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EAB")]
		public ProductUserId UserId
		{
			[Token(Token = "0x60030CE")]
			[Address(RVA = "0x589F90", Offset = "0x588590", VA = "0x180589F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030CF")]
			[Address(RVA = "0x58A070", Offset = "0x588670", VA = "0x18058A070")]
			set
			{
			}
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x589D40", Offset = "0x588340", VA = "0x180589D40", Slot = "6")]
		public void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfo other)
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x589E00", Offset = "0x588400", VA = "0x180589E00", Slot = "7")]
		public void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfo? other)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x589CC0", Offset = "0x5882C0", VA = "0x180589CC0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x589D20", Offset = "0x588320", VA = "0x180589D20", Slot = "5")]
		public void Get(out OnQueryPlayerAchievementsCompleteCallbackInfo output)
		{
		}

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_UserId;
	}
}
