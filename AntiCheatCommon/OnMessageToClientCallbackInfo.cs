using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public struct OnMessageToClientCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D69")]
		public object ClientData
		{
			[Token(Token = "0x6002D1F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002D20")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x0000B99C File Offset: 0x00009B9C
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D6A")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D21")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002D22")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D6B")]
		public ArraySegment<byte> MessageData
		{
			[Token(Token = "0x6002D23")]
			[Address(RVA = "0x4EC380", Offset = "0x4EA980", VA = "0x1804EC380")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002D24")]
			[Address(RVA = "0x578960", Offset = "0x576F60", VA = "0x180578960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0000B9CC File Offset: 0x00009BCC
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x578870", Offset = "0x576E70", VA = "0x180578870")]
		internal void Set(ref OnMessageToClientCallbackInfoInternal other)
		{
		}
	}
}
