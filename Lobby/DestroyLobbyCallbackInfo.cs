using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public struct DestroyLobbyCallbackInfo : ICallbackInfo
	{
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x000071B4 File Offset: 0x000053B4
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006FD")]
		public Result ResultCode
		{
			[Token(Token = "0x600191F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001920")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006FE")]
		public object ClientData
		{
			[Token(Token = "0x6001921")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001922")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006FF")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001923")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000071CC File Offset: 0x000053CC
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x50A2E0", Offset = "0x5088E0", VA = "0x18050A2E0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x50A330", Offset = "0x508930", VA = "0x18050A330")]
		internal void Set(ref DestroyLobbyCallbackInfoInternal other)
		{
		}
	}
}
