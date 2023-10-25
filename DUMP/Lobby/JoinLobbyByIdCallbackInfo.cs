using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public struct JoinLobbyByIdCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000732")]
		public Result ResultCode
		{
			[Token(Token = "0x600199E")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600199F")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000733")]
		public object ClientData
		{
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000734")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019A3")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x50E6D0", Offset = "0x50CCD0", VA = "0x18050E6D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x50E720", Offset = "0x50CD20", VA = "0x18050E720")]
		internal void Set(ref JoinLobbyByIdCallbackInfoInternal other)
		{
		}
	}
}
