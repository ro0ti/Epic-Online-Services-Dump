using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public struct CreateLobbyCallbackInfo : ICallbackInfo
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D8")]
		public Result ResultCode
		{
			[Token(Token = "0x60018D9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60018DA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D9")]
		public object ClientData
		{
			[Token(Token = "0x60018DB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006DA")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60018DD")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60018DE")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x508F40", Offset = "0x507540", VA = "0x180508F40", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x508F90", Offset = "0x507590", VA = "0x180508F90")]
		internal void Set(ref CreateLobbyCallbackInfoInternal other)
		{
		}
	}
}
