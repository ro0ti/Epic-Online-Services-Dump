using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	internal struct PresenceChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PresenceChangedCallbackInfo>, ISettable<PresenceChangedCallbackInfo>, IDisposable
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000507")]
		public object ClientData
		{
			[Token(Token = "0x6001318")]
			[Address(RVA = "0x4FABE0", Offset = "0x4F91E0", VA = "0x1804FABE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001319")]
			[Address(RVA = "0x4FAD50", Offset = "0x4F9350", VA = "0x1804FAD50")]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x17000508")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600131A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000509")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600131B")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9250", VA = "0x1804FAC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600131C")]
			[Address(RVA = "0x4FADB0", Offset = "0x4F93B0", VA = "0x1804FADB0")]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700050A")]
		public EpicAccountId PresenceUserId
		{
			[Token(Token = "0x600131D")]
			[Address(RVA = "0x4FACD0", Offset = "0x4F92D0", VA = "0x1804FACD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600131E")]
			[Address(RVA = "0x4FAE10", Offset = "0x4F9410", VA = "0x1804FAE10")]
			set
			{
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x4FAAE0", Offset = "0x4F90E0", VA = "0x1804FAAE0", Slot = "6")]
		public void Set(ref PresenceChangedCallbackInfo other)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x4FA980", Offset = "0x4F8F80", VA = "0x1804FA980", Slot = "7")]
		public void Set(ref PresenceChangedCallbackInfo? other)
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x4FA900", Offset = "0x4F8F00", VA = "0x1804FA900", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x4FA960", Offset = "0x4F8F60", VA = "0x1804FA960", Slot = "5")]
		public void Get(out PresenceChangedCallbackInfo output)
		{
		}

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PresenceUserId;
	}
}
