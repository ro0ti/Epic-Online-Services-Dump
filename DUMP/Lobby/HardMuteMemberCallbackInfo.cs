using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public struct HardMuteMemberCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0000722C File Offset: 0x0000542C
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000716")]
		public Result ResultCode
		{
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600195D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000717")]
		public object ClientData
		{
			[Token(Token = "0x600195E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600195F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000718")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001960")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001961")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000719")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001962")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001963")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x50C810", Offset = "0x50AE10", VA = "0x18050C810", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x50C860", Offset = "0x50AE60", VA = "0x18050C860")]
		internal void Set(ref HardMuteMemberCallbackInfoInternal other)
		{
		}
	}
}
