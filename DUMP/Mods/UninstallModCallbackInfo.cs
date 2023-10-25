using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	public struct UninstallModCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00006B9C File Offset: 0x00004D9C
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000685")]
		public Result ResultCode
		{
			[Token(Token = "0x60017CD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60017CE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000686")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017CF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017D0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000687")]
		public object ClientData
		{
			[Token(Token = "0x60017D1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017D2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00006BB4 File Offset: 0x00004DB4
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000688")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017D3")]
			[Address(RVA = "0x50D620", Offset = "0x50BC20", VA = "0x18050D620")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x50D640", Offset = "0x50BC40", VA = "0x18050D640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x520450", Offset = "0x51EA50", VA = "0x180520450", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0")]
		internal void Set(ref UninstallModCallbackInfoInternal other)
		{
		}
	}
}
