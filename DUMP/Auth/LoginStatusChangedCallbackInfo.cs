using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	public struct LoginStatusChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C45")]
		public object ClientData
		{
			[Token(Token = "0x6002A06")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A07")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C46")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A08")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A09")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0000A8EC File Offset: 0x00008AEC
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C47")]
		public LoginStatus PrevStatus
		{
			[Token(Token = "0x6002A0A")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002A0B")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0000A904 File Offset: 0x00008B04
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C48")]
		public LoginStatus CurrentStatus
		{
			[Token(Token = "0x6002A0C")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002A0D")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0000A91C File Offset: 0x00008B1C
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x55F740", Offset = "0x55DD40", VA = "0x18055F740")]
		internal void Set(ref LoginStatusChangedCallbackInfoInternal other)
		{
		}
	}
}
