using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable
	{
		// Token: 0x1700021C RID: 540
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x4C5C10", Offset = "0x4C4210", VA = "0x1804C5C10")]
			set
			{
			}
		}

		// Token: 0x1700021D RID: 541
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021D")]
		public Utf8String InviteId
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x4C5BB0", Offset = "0x4C41B0", VA = "0x1804C5BB0")]
			set
			{
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x4C59E0", Offset = "0x4C3FE0", VA = "0x1804C59E0", Slot = "4")]
		public void Set(ref RejectInviteOptions other)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x4C5AA0", Offset = "0x4C40A0", VA = "0x1804C5AA0", Slot = "5")]
		public void Set(ref RejectInviteOptions? other)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x4C5980", Offset = "0x4C3F80", VA = "0x1804C5980", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_InviteId;
	}
}
