using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	public struct SendCustomInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x00009D34 File Offset: 0x00007F34
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B21")]
		public Result ResultCode
		{
			[Token(Token = "0x6002675")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002676")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B22")]
		public object ClientData
		{
			[Token(Token = "0x6002677")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002678")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B23")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002679")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600267A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B24")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x600267B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600267C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x566C20", Offset = "0x565220", VA = "0x180566C20", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x566C70", Offset = "0x565270", VA = "0x180566C70")]
		internal void Set(ref SendCustomInviteCallbackInfoInternal other)
		{
		}
	}
}
