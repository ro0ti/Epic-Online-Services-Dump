using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000619 RID: 1561
	[Token(Token = "0x2000619")]
	public struct LoginStatusChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAE")]
		public object ClientData
		{
			[Token(Token = "0x600280D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600280E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600280F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002810")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x0000A28C File Offset: 0x0000848C
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB0")]
		public LoginStatus PreviousStatus
		{
			[Token(Token = "0x6002811")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002812")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0000A2A4 File Offset: 0x000084A4
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB1")]
		public LoginStatus CurrentStatus
		{
			[Token(Token = "0x6002813")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002814")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0000A2BC File Offset: 0x000084BC
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x55F7F0", Offset = "0x55DDF0", VA = "0x18055F7F0")]
		internal void Set(ref LoginStatusChangedCallbackInfoInternal other)
		{
		}
	}
}
