using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	public struct AudioBeforeRenderCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F2")]
		public object ClientData
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F4")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000045A4 File Offset: 0x000027A4
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F5")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x4D5010", Offset = "0x4D3610", VA = "0x1804D5010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F6")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x4D4E50", Offset = "0x4D3450", VA = "0x1804D4E50")]
		internal void Set(ref AudioBeforeRenderCallbackInfoInternal other)
		{
		}
	}
}
