using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public struct ShowFriendsCallbackInfo : ICallbackInfo
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00002D44 File Offset: 0x00000F44
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E9")]
		public Result ResultCode
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EA")]
		public object ClientData
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4B0490", Offset = "0x4AEA90", VA = "0x1804B0490", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4B04E0", Offset = "0x4AEAE0", VA = "0x1804B04E0")]
		internal void Set(ref ShowFriendsCallbackInfoInternal other)
		{
		}
	}
}
