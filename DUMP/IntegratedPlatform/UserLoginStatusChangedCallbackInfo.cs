using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	public struct UserLoginStatusChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000928")]
		public object ClientData
		{
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000929")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092A")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002063")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092B")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092C")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x00008B64 File Offset: 0x00006D64
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092D")]
		public LoginStatus PreviousLoginStatus
		{
			[Token(Token = "0x6002068")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x00008B7C File Offset: 0x00006D7C
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092E")]
		public LoginStatus CurrentLoginStatus
		{
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x3D2E90", Offset = "0x3D1490", VA = "0x1803D2E90")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x3D2EC0", Offset = "0x3D14C0", VA = "0x1803D2EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00008B94 File Offset: 0x00006D94
		[Token(Token = "0x600206C")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x552030", Offset = "0x550630", VA = "0x180552030")]
		internal void Set(ref UserLoginStatusChangedCallbackInfoInternal other)
		{
		}
	}
}
