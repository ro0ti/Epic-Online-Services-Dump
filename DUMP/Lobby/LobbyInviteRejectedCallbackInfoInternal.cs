using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	internal struct LobbyInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteRejectedCallbackInfo>, ISettable<LobbyInviteRejectedCallbackInfo>, IDisposable
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007BE")]
		public object ClientData
		{
			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0x528D70", Offset = "0x527370", VA = "0x180528D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0x528FC0", Offset = "0x5275C0", VA = "0x180528FC0")]
			set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[Token(Token = "0x170007BF")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C0")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B4F")]
			[Address(RVA = "0x528DE0", Offset = "0x5273E0", VA = "0x180528DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0x529020", Offset = "0x527620", VA = "0x180529020")]
			set
			{
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0x528EC0", Offset = "0x5274C0", VA = "0x180528EC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B52")]
			[Address(RVA = "0x5290E0", Offset = "0x5276E0", VA = "0x1805290E0")]
			set
			{
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C2")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B53")]
			[Address(RVA = "0x528F40", Offset = "0x527540", VA = "0x180528F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x529140", Offset = "0x527740", VA = "0x180529140")]
			set
			{
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C3")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B55")]
			[Address(RVA = "0x528E50", Offset = "0x527450", VA = "0x180528E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B56")]
			[Address(RVA = "0x529080", Offset = "0x527680", VA = "0x180529080")]
			set
			{
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x528BF0", Offset = "0x5271F0", VA = "0x180528BF0", Slot = "6")]
		public void Set(ref LobbyInviteRejectedCallbackInfo other)
		{
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x5289E0", Offset = "0x526FE0", VA = "0x1805289E0", Slot = "7")]
		public void Set(ref LobbyInviteRejectedCallbackInfo? other)
		{
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x528930", Offset = "0x526F30", VA = "0x180528930", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x5289B0", Offset = "0x526FB0", VA = "0x1805289B0", Slot = "5")]
		public void Get(out LobbyInviteRejectedCallbackInfo output)
		{
		}

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_LobbyId;
	}
}
