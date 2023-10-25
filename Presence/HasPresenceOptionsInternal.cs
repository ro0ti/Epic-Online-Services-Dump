using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	internal struct HasPresenceOptionsInternal : ISettable<HasPresenceOptions>, IDisposable
	{
		// Token: 0x170004E5 RID: 1253
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E5")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012AF")]
			[Address(RVA = "0x4F2910", Offset = "0x4F0F10", VA = "0x1804F2910")]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E6")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012B0")]
			[Address(RVA = "0x4F2970", Offset = "0x4F0F70", VA = "0x1804F2970")]
			set
			{
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x4F2740", Offset = "0x4F0D40", VA = "0x1804F2740", Slot = "4")]
		public void Set(ref HasPresenceOptions other)
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x4F2800", Offset = "0x4F0E00", VA = "0x1804F2800", Slot = "5")]
		public void Set(ref HasPresenceOptions? other)
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x4F26E0", Offset = "0x4F0CE0", VA = "0x1804F26E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
