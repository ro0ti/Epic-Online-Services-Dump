using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	public struct JoinLobbyCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x000073AC File Offset: 0x000055AC
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000743")]
		public Result ResultCode
		{
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000744")]
		public object ClientData
		{
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000745")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x50F280", Offset = "0x50D880", VA = "0x18050F280", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x50F2D0", Offset = "0x50D8D0", VA = "0x18050F2D0")]
		internal void Set(ref JoinLobbyCallbackInfoInternal other)
		{
		}
	}
}
