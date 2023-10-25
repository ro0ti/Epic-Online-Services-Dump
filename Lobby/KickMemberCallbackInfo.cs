using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D5 RID: 981
	[Token(Token = "0x20003D5")]
	public struct KickMemberCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00007454 File Offset: 0x00005654
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000754")]
		public Result ResultCode
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000755")]
		public object ClientData
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000756")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0000746C File Offset: 0x0000566C
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x50FE00", Offset = "0x50E400", VA = "0x18050FE00", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x50FE50", Offset = "0x50E450", VA = "0x18050FE50")]
		internal void Set(ref KickMemberCallbackInfoInternal other)
		{
		}
	}
}
