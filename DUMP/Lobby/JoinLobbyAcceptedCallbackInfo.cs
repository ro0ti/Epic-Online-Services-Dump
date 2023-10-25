using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CB RID: 971
	[Token(Token = "0x20003CB")]
	public struct JoinLobbyAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700072B")]
		public object ClientData
		{
			[Token(Token = "0x600198B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600198C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700072C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600198E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000072A4 File Offset: 0x000054A4
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700072D")]
		public ulong UiEventId
		{
			[Token(Token = "0x600198F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001990")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000072BC File Offset: 0x000054BC
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x50E220", Offset = "0x50C820", VA = "0x18050E220")]
		internal void Set(ref JoinLobbyAcceptedCallbackInfoInternal other)
		{
		}
	}
}
