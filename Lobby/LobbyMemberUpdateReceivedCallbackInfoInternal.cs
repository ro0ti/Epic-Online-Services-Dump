using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	internal struct LobbyMemberUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberUpdateReceivedCallbackInfo>, ISettable<LobbyMemberUpdateReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D0")]
		public object ClientData
		{
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x529C90", Offset = "0x528290", VA = "0x180529C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B7B")]
			[Address(RVA = "0x529DF0", Offset = "0x5283F0", VA = "0x180529DF0")]
			set
			{
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00007B74 File Offset: 0x00005D74
		[Token(Token = "0x170007D1")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001B7C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D2")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0x529D00", Offset = "0x528300", VA = "0x180529D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0x529E50", Offset = "0x528450", VA = "0x180529E50")]
			set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0x529D70", Offset = "0x528370", VA = "0x180529D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B80")]
			[Address(RVA = "0x529EB0", Offset = "0x5284B0", VA = "0x180529EB0")]
			set
			{
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x529A30", Offset = "0x528030", VA = "0x180529A30", Slot = "6")]
		public void Set(ref LobbyMemberUpdateReceivedCallbackInfo other)
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x529B30", Offset = "0x528130", VA = "0x180529B30", Slot = "7")]
		public void Set(ref LobbyMemberUpdateReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x5299B0", Offset = "0x527FB0", VA = "0x1805299B0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x529A10", Offset = "0x528010", VA = "0x180529A10", Slot = "5")]
		public void Get(out LobbyMemberUpdateReceivedCallbackInfo output)
		{
		}

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
