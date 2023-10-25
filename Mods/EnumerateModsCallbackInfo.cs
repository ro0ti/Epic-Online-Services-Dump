using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	public struct EnumerateModsCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000069EC File Offset: 0x00004BEC
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065B")]
		public Result ResultCode
		{
			[Token(Token = "0x6001739")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600173A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600173B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600173C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065D")]
		public object ClientData
		{
			[Token(Token = "0x600173D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600173E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00006A04 File Offset: 0x00004C04
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065E")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x600173F")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x6001740")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x50B5F0", Offset = "0x509BF0", VA = "0x18050B5F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x50B640", Offset = "0x509C40", VA = "0x18050B640")]
		internal void Set(ref EnumerateModsCallbackInfoInternal other)
		{
		}
	}
}
