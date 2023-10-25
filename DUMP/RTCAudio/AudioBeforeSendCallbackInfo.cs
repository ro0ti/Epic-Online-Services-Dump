using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	public struct AudioBeforeSendCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FD")]
		public object ClientData
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FF")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00004604 File Offset: 0x00002804
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000300")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x4D5010", Offset = "0x4D3610", VA = "0x1804D5010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x4D5780", Offset = "0x4D3D80", VA = "0x1804D5780")]
		internal void Set(ref AudioBeforeSendCallbackInfoInternal other)
		{
		}
	}
}
