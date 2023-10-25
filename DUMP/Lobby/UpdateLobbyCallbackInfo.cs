using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000476 RID: 1142
	[Token(Token = "0x2000476")]
	public struct UpdateLobbyCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000081EC File Offset: 0x000063EC
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000856")]
		public Result ResultCode
		{
			[Token(Token = "0x6001DAA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001DAB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000857")]
		public object ClientData
		{
			[Token(Token = "0x6001DAC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DAD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000858")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00008204 File Offset: 0x00006404
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x537920", Offset = "0x535F20", VA = "0x180537920", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x537970", Offset = "0x535F70", VA = "0x180537970")]
		internal void Set(ref UpdateLobbyCallbackInfoInternal other)
		{
		}
	}
}
