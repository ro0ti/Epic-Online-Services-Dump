using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public struct UnregisterPlayersCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000043C4 File Offset: 0x000025C4
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A9")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AA")]
		public object ClientData
		{
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AB")]
		public ProductUserId[] UnregisteredPlayers
		{
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x4E7180", Offset = "0x4E5780", VA = "0x1804E7180", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x4E71D0", Offset = "0x4E57D0", VA = "0x1804E71D0")]
		internal void Set(ref UnregisterPlayersCallbackInfoInternal other)
		{
		}
	}
}
