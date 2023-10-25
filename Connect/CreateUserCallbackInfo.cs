using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005FD RID: 1533
	[Token(Token = "0x20005FD")]
	public struct CreateUserCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x0000A01C File Offset: 0x0000821C
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B68")]
		public Result ResultCode
		{
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002756")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002758 RID: 10072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B69")]
		public object ClientData
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002758")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B6A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002759")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600275A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0000A034 File Offset: 0x00008234
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x558DA0", Offset = "0x5573A0", VA = "0x180558DA0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x558DF0", Offset = "0x5573F0", VA = "0x180558DF0")]
		internal void Set(ref CreateUserCallbackInfoInternal other)
		{
		}
	}
}
