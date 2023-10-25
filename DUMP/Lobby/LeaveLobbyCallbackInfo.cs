using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	public struct LeaveLobbyCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x000074B4 File Offset: 0x000056B4
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000761")]
		public Result ResultCode
		{
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000762")]
		public object ClientData
		{
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000763")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A0C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x510730", Offset = "0x50ED30", VA = "0x180510730", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x510780", Offset = "0x50ED80", VA = "0x180510780")]
		internal void Set(ref LeaveLobbyCallbackInfoInternal other)
		{
		}
	}
}
