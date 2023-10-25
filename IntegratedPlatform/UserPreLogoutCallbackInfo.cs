using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	public struct UserPreLogoutCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000937")]
		public object ClientData
		{
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000938")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000939")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700093A")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700093B")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600208A")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x552A30", Offset = "0x551030", VA = "0x180552A30")]
		internal void Set(ref UserPreLogoutCallbackInfoInternal other)
		{
		}
	}
}
