using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065C RID: 1628
	[Token(Token = "0x200065C")]
	public struct LinkAccountCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x0000A73C File Offset: 0x0000893C
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1F")]
		public Result ResultCode
		{
			[Token(Token = "0x60029B0")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60029B1")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C20")]
		public object ClientData
		{
			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029B3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C21")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029B4")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029B5")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x0000A754 File Offset: 0x00008954
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C22")]
		public PinGrantInfo? PinGrantInfo
		{
			[Token(Token = "0x60029B6")]
			[Address(RVA = "0x4C8050", Offset = "0x4C6650", VA = "0x1804C8050")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029B7")]
			[Address(RVA = "0x4C8080", Offset = "0x4C6680", VA = "0x1804C8080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C23")]
		public EpicAccountId SelectedAccountId
		{
			[Token(Token = "0x60029B8")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029B9")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0000A76C File Offset: 0x0000896C
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x55CB40", Offset = "0x55B140", VA = "0x18055CB40", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x55CBE0", Offset = "0x55B1E0", VA = "0x18055CBE0")]
		internal void Set(ref LinkAccountCallbackInfoInternal other)
		{
		}
	}
}
