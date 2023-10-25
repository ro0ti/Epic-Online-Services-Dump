using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	public struct LogoutCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0000A97C File Offset: 0x00008B7C
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C4E")]
		public Result ResultCode
		{
			[Token(Token = "0x6002A1D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002A1E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C4F")]
		public object ClientData
		{
			[Token(Token = "0x6002A1F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C50")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A21")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A22")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x0000A994 File Offset: 0x00008B94
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x55FCB0", Offset = "0x55E2B0", VA = "0x18055FCB0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x55FD00", Offset = "0x55E300", VA = "0x18055FD00")]
		internal void Set(ref LogoutCallbackInfoInternal other)
		{
		}
	}
}
