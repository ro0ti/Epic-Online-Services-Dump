using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable
	{
		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C49")]
		public object ClientData
		{
			[Token(Token = "0x6002A10")]
			[Address(RVA = "0x55F450", Offset = "0x55DA50", VA = "0x18055F450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A11")]
			[Address(RVA = "0x55F5C0", Offset = "0x55DBC0", VA = "0x18055F5C0")]
			set
			{
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x0000A934 File Offset: 0x00008B34
		[Token(Token = "0x17000C4A")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002A12")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C4B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A13")]
			[Address(RVA = "0x55F540", Offset = "0x55DB40", VA = "0x18055F540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A14")]
			[Address(RVA = "0x55F6E0", Offset = "0x55DCE0", VA = "0x18055F6E0")]
			set
			{
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0000A94C File Offset: 0x00008B4C
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C4C")]
		public LoginStatus PrevStatus
		{
			[Token(Token = "0x6002A15")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002A16")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0000A964 File Offset: 0x00008B64
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C4D")]
		public LoginStatus CurrentStatus
		{
			[Token(Token = "0x6002A17")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002A18")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x55EFC0", Offset = "0x55D5C0", VA = "0x18055EFC0", Slot = "6")]
		public void Set(ref LoginStatusChangedCallbackInfo other)
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x55F090", Offset = "0x55D690", VA = "0x18055F090", Slot = "7")]
		public void Set(ref LoginStatusChangedCallbackInfo? other)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x55EF20", Offset = "0x55D520", VA = "0x18055EF20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x55EF80", Offset = "0x55D580", VA = "0x18055EF80", Slot = "5")]
		public void Get(out LoginStatusChangedCallbackInfo output)
		{
		}

		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0x10")]
		private LoginStatus m_PrevStatus;

		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0x14")]
		private LoginStatus m_CurrentStatus;
	}
}
