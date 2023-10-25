using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable
	{
		// Token: 0x17000994 RID: 2452
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000994")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x550D40", Offset = "0x54F340", VA = "0x180550D40")]
			set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000995")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x550DA0", Offset = "0x54F3A0", VA = "0x180550DA0")]
			set
			{
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x550B70", Offset = "0x54F170", VA = "0x180550B70", Slot = "4")]
		public void Set(ref SendInviteOptions other)
		{
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x550C30", Offset = "0x54F230", VA = "0x180550C30", Slot = "5")]
		public void Set(ref SendInviteOptions? other)
		{
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x550B10", Offset = "0x54F110", VA = "0x180550B10", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
